﻿//using Sql.Data.SqlClient;
using ProjectCSIS3540;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectCSIS3540
{
    public partial class CheckOut : Form
    {
        SqlConnection con = null;
        SqlDataAdapter mcmd;
        SqlCommand cmd;
        int product_id, location_id, client_id;
        decimal length, width, height;
        int weight;
        int dim;
        decimal priceMonth = 0m;
        //price for all the products checkout 
        decimal price = 0m;
        decimal tax = 0m;
        decimal tPrice = 0m;
        decimal palletMonth = 0m;
        DateTime checkIn, checkOut;
        TimeSpan difference;
       

        public CheckOut(SqlConnection conn)
        {
            InitializeComponent();
            con = conn;
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            cmd = new SqlCommand();
            mcmd = new SqlDataAdapter();
        }

        public void DisplayTables(string query, DataGridView dgv, string tableName)
        {
            cmd.CommandText = query;
            cmd.Connection = con;
            mcmd.SelectCommand = cmd;
            DataSet ds = new DataSet();
            mcmd.Fill(ds, tableName);
            dgv.DataSource = ds.Tables[tableName];
            mcmd.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                //con.Open();
                string instruction = "SELECT * FROM Client2 ";
                if (txtcname.Text.Length > 0)
                {
                    instruction += " WHERE client_name = '" + txtcname.Text + "'";

                }
                DisplayTables(instruction, dg1, "clients");
                //con.Close();
            }
        }


        //display product info from the datagrid current select row
        public void displayP()
        {

            txtOID.Text = dg1.CurrentRow.Cells[1].Value.ToString();
            txtPID.Text = dg1.CurrentRow.Cells[2].Value.ToString();
            txtDesc.Text = dg1.CurrentRow.Cells[3].Value.ToString();
            txtNa.Text = dg1.CurrentRow.Cells[4].Value.ToString();
            txtQu.Text = dg1.CurrentRow.Cells[5].Value.ToString();
            txtUnit.Text = dg1.CurrentRow.Cells[6].Value.ToString();
            txtLe.Text = dg1.CurrentRow.Cells[7].Value.ToString();
            txtWi.Text = dg1.CurrentRow.Cells[8].Value.ToString();
            txtHe.Text = dg1.CurrentRow.Cells[9].Value.ToString();
            txtWe.Text = dg1.CurrentRow.Cells[10].Value.ToString();
            txtCI.Text = dg1.CurrentRow.Cells[11].Value.ToString();
            txtCO.Text = dg1.CurrentRow.Cells[12].Value.ToString();
            txtEp.Text = dg1.CurrentRow.Cells[13].Value.ToString();
            txtLo.Text = dg1.CurrentRow.Cells[14].Value.ToString();
                

        }


        //add the click event to the datagrid eventhander 
        //search to show client information, click to show related order and product infomation
        //need to improve, when the client name text box text change, rearrange the client info,
        //when the product name and product sort methods combobox changed, rearrange the product info
        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCheckOut.Enabled = true;
            string TableName = ((DataTable)dg1.DataSource).TableName;
            if (TableName == "clients")
            {
                
                client_id = int.Parse(dg1.SelectedRows[0].Cells[0].Value.ToString());
                //search and display products on the datagrid view
                se_display_product();
            }
            else if (TableName == "products")
            {
                //check out date is not empty
                if(dg1.CurrentRow.Cells[12].Value.ToString() != String.Empty)
                {
                    MessageBox.Show("this product is already checked out!");
                    btnCheckOut.Enabled = false;
                }
                else
                {
                    displayP();
                }
                   
            }
        }

        //
        private string default_product()
        {
            string instruction = " select client_id, p.order_id, product_id, description, name, quantity, unit,";
            instruction += "length, width, height, weight, check_in_date, check_out_date, expire_date, location_id, bill ";
            instruction += " from Orders o ";
            instruction += " INNER JOIN Product2 p ";
            instruction += " ON o.order_id = p.order_id ";
            instruction += " WHERE o.client_id = @Client_id ";
            return instruction;
        }

        //
        private string product_byName(string instruction)
        {
            if (txtPN.Text.Length > 0)
            {
                if (cmd.Parameters.Contains("@P_name"))
                {
                    cmd.Parameters["@P_name"].Value = txtPN.Text;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@P_name", txtPN.Text);
                }
                instruction += " AND p.name = @P_name";
            }
            return instruction;
        }
        //
        private string product_byDate(string instruction)

        {
            if (comOrder.SelectedIndex != -1)
            {
                if (comOrder.SelectedIndex == 0)
                {
                    instruction += " ORDER BY check_in_date ASC";
                }
                else
                {
                    instruction += " ORDER BY expire_date ASC";
                }

            }
            return instruction;
        }
        // 
        private void se_display_product()
        {
            //add client_id if not exitst
            if (!cmd.Parameters.Contains("@Client_id"))
            {
                cmd.Parameters.Add("@Client_id", SqlDbType.Int);
            }
            cmd.Parameters["@Client_id"].Value = client_id;

            //default product search based on client id clicked
            string instruction = default_product();

            //product search by name (plus)
            instruction = product_byName(instruction);

            //product search by date (plus)
            instruction = product_byDate(instruction);

            //display product search result in datagrid view
            DisplayTables(instruction, dg1, "products");
        }

        //check out product when the whole product is checked out
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //txtCO.Enabled = true;
            if (con != null)
            {
                //con.Open();
                cmd.Parameters.Clear();
                //the product has not been check out

                if (txtPID.Text.Length > 0 && txtLo.Text.Length > 0)
                {
                    product_id = int.Parse(txtPID.Text);
                    location_id = int.Parse(txtLo.Text);

                    //update pallet current_volumn and current_weight
                    upLocation();
                    //calculate price based on the storing time
                    calPrice();
                    //refresh the product result
                    se_display_product();
                }
                
            }
        }


        //refresh the product when input new date category (check in or expiration)
        private void comOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TableName = ((DataTable)dg1.DataSource).TableName;
            if(TableName == "products")
            {
                se_display_product();
            }
            else if (TableName == "clients")
            {
                MessageBox.Show("please click the desired client first");
            }
            
        }

        //refresh the product when input new product name
        private void txtPN_TextChanged(object sender, EventArgs e)
        {
            string TableName = ((DataTable)dg1.DataSource).TableName;
            if (TableName == "products")
            {
                se_display_product();
            }
            else if (TableName == "clients")
            {
                MessageBox.Show("please click the desired client first");
            }
        }



        //update location table both volumn and weight when the whole product is checked out
        public void upLocation()
        {
            if (txtLe.Text.Length > 0 && txtWi.Text.Length > 0 && txtHe.Text.Length > 0 && txtWe.Text.Length > 0)
            {
                length = Convert.ToDecimal(txtLe.Text);
                width = Convert.ToDecimal(txtWi.Text);
                height = Convert.ToDecimal(txtHe.Text);
                weight = Decimal.ToInt32(Convert.ToDecimal(txtWe.Text));

                dim = Decimal.ToInt32(length * width * height);
                string instruction = "update Location set current_volumn = current_volumn - @dim, ";
                instruction += " current_weight = current_weight - @we ";
                instruction += " where location_id = @location_id ";
                cmd.Parameters.AddWithValue("@dim", dim);
                cmd.Parameters.AddWithValue("@we", weight);
                cmd.Parameters.AddWithValue("@location_id", location_id);
                cmd.CommandText = instruction;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();


            }

        }

       

        //find the pallet_month price from Pallet and location table
        public void getLoPrice()
        {
            string instruction = "select Pallet_price ";
            instruction += " from Location lo ";
            instruction += " INNER JOIN Pallet pa ";
            instruction += " ON lo.Pallet_id = pa.Pallet_id ";
            instruction += " WHERE location_id = @location_id ";
            //cmd.Parameters.AddWithValue("@location_id", location_id);
            cmd.CommandText = instruction;
            cmd.Connection = con;
            palletMonth = (decimal)cmd.ExecuteScalar();

        }
        public void calPrice()
        {
            //get location price per month
            getLoPrice();

            if (txtCO.Text.Length > 0 && txtCI.Text.Length > 0)
            {
                //check out price for each product
                decimal unit_price = 0.00m;
                string checkout_date;
                checkout_date = txtCO.Text;
                CheckIn checkin = new CheckIn(con);
                if (checkin.date_validation(checkout_date))
                {
                    checkIn = DateTime.Parse(txtCI.Text);
                    checkOut = DateTime.Parse(txtCO.Text);
                    difference = checkOut - checkIn;
                    int days = Convert.ToInt32(difference.TotalDays);
                    decimal month = Math.Ceiling(((decimal)days / 30));
                    priceMonth = ((decimal)dim / 110592) * palletMonth;
                    unit_price = Math.Round((priceMonth * month), 2);
                    //update bill and check out date into product table
                    update_product(unit_price, checkout_date);
                    //calculate the add up price when multiple products checked out
                    price = price + unit_price;
                    tax = price * 0.13m;
                    tPrice = Math.Round((price + tax), 2);
                    txtPrice.Text = price.ToString();
                    txtTax.Text = tax.ToString();
                    txtTotal.Text = tPrice.ToString();
                }
                else
                {
                    MessageBox.Show("Please input valid check out date!");
                }
               
            }
            else
            {
                MessageBox.Show("please input the checkout date to calculate");
            }

        }

        //update check out price into product table
        private void update_product(decimal unit_price, string checkout_date)
        {
            string instruction = " update Product2 set bill = @bill, check_out_date = @check_out ";
            instruction += " where product_id = @pro_id ";
            cmd.Parameters.AddWithValue("@bill", unit_price);
            cmd.Parameters.AddWithValue("@pro_id", product_id);
            cmd.Parameters.AddWithValue("@check_out", checkout_date);
            cmd.CommandText = instruction;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
       
        //reset and clear any information
        private void button1_Click(object sender, EventArgs e)
        {

            product_id = 0;
            location_id = 0;
            length = 0;
            width = 0;
            height = 0;
            weight = 0;
            dim = 0;
            priceMonth = 0.00m;
            price = 0m;
            tax = 0m;
            tPrice = 0m;
            palletMonth = 0m;
            checkIn = DateTime.MinValue;
            checkOut = DateTime.MinValue;
            difference = TimeSpan.Zero;
            txtcname.Clear();
            txtPN.Clear();
            comOrder.SelectedIndex = -1;
            txtPrice.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtOID.Clear();
            txtPID.Clear();
            txtDesc.Clear();
            txtNa.Clear();
            txtQu.Clear();
            txtUnit.Clear();
            txtLe.Clear();
            txtWi.Clear();
            txtHe.Clear();
            txtWe.Clear();
            txtEp.Clear();
            txtCI.Clear();
            txtCO.Clear();
            txtLo.Clear();
            dg1.DataSource = null;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(con);
            mainpage.Show();
            this.Hide();
        }

    }
}
