using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Sql.Data.SqlClient;
using System.Data.SqlClient;

namespace ProjectCSIS3540
{
    public partial class CheckIn : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter mcmd;
        int order_id = 0;
        int product_id = 0;
        decimal length, width, height = 0.00m;
        int dim = 0;
        int aisleno = 0;
        int weight = 0;
        int pallet_capa = 0;
        //int pallet_id = 0;
        int c_vol = 0;
        int c_wei = 0;
        int location_id = 0;
        decimal Price = 0.00m;
        decimal Pallet_price = 0.00m;

        public CheckIn(SqlConnection conn)
        {
            InitializeComponent();
            con = conn;
        }


        //add new client to the database

        private void CheckIn_Load(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand();
            mcmd = new SqlDataAdapter();

        }

        private void locate()
        {
            //decide aisile number based on product description
            if (desCombo.SelectedIndex != -1)
            {
                string desc = desCombo.SelectedItem.ToString();
                switch (desc)
                {
                    case "food":
                        aisleno = 1;
                        break;
                    case "garment":
                        aisleno = 2;
                        break;
                    case "book":
                        aisleno = 3;
                        break;
                    case "cable":
                        aisleno = 4;
                        break;
                    case "appliance":
                        aisleno = 5;
                        break;
                    case "furniture":
                        aisleno = 6;
                        break;
                    case "drink":
                        aisleno = 7;
                        break;
                }//end of switch case //assumptions

            }
            else
            {
                MessageBox.Show("please choose the description!");
            }


            //get the volumn of the product

            if (txtLe.Text != null && txtWi.Text != null && txtHe != null)
            {
                length = Convert.ToDecimal(txtLe.Text);
                height = Convert.ToDecimal(txtHe.Text);
                width = Convert.ToDecimal(txtWi.Text);
                dim = Decimal.ToInt32(length * width * height);

            }
            else
            {
                MessageBox.Show("please input the dimension of the product!");
            }


            //decide pallet_capacity and pallet_price based on the weight input

            if (txtWe.Text != null)
            {
                weight = Decimal.ToInt32(Convert.ToDecimal(txtWe.Text));
                if (weight <= 20)
                {
                    pallet_capa = 1000;
                    Pallet_price = 6.00m;
                }
                if (weight > 20.00m && weight <= 50)
                {
                    pallet_capa = 2000;
                    Pallet_price = 11.00m;
                }
                if (weight > 50)
                {
                    pallet_capa = 3000;
                    Pallet_price = 17.00m;
                } //assumptions

            }
            else
            {
                MessageBox.Show("please input the weight!");
            }

            //query the location table from database to decide which location_id 
            if (pallet_capa != 0 && aisleno != 0 && dim != 0)
            {
                //get the available location_id
                findLocation();

            }

            if (location_id == 0)
            {
                MessageBox.Show("no location is available!");
            }
            else
            {
                
                //update Product2 location information

                updateProduct();

                //update the current_volumn and current_weight info of location table

                updateLocation();


            }



        }

        public void insertProduct()
        {
            string instruction = "INSERT INTO Product2 (description, name, quantity, unit,";
            instruction += " length, width, height, check_in_date, weight, expire_date, order_id) ";
            instruction += " output INSERTED.product_id ";
            instruction += " VALUES(@des, @name, @quan, @unit, @le, @wi, @he, @ci, @we, @exp,@order_id) ";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@des", desCombo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@name", txtNa.Text);
            cmd.Parameters.AddWithValue("@quan", int.Parse(txtQu.Text));
            cmd.Parameters.AddWithValue("@unit", unitCombo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@le", decimal.Parse(txtLe.Text));
            cmd.Parameters.AddWithValue("@wi", decimal.Parse(txtWi.Text));
            cmd.Parameters.AddWithValue("@he", decimal.Parse(txtHe.Text));
            cmd.Parameters.AddWithValue("@ci", txtCI.Text);
            cmd.Parameters.AddWithValue("@we", decimal.Parse(txtWe.Text));
            cmd.Parameters.AddWithValue("@exp", txtEp.Text);
            cmd.Parameters.AddWithValue("@order_id", order_id);
            //cmd.ExecuteNonQuery();
            product_id = (int)cmd.ExecuteScalar();
            //product_id = Convert.ToInt32(cmd.LastInsertedId);
            txtPID.Text = product_id.ToString();

        }



        public void findLocation()
        {
            string instruction = "Select location_id, current_volumn, current_weight ";
            instruction += " from Location lo ";
            instruction += " INNER JOIN Pallet pa ";
            instruction += " ON lo.Pallet_id = pa.Pallet_id ";
            instruction += " where Pallet_capacity = @p_capa AND asile_id = @a_num";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@p_capa", pallet_capa);
            cmd.Parameters.AddWithValue("@a_num", aisleno);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                c_vol = Convert.ToInt32(dataReader["current_volumn"]);
                c_wei = Convert.ToInt32(dataReader["current_weight"]);
                if (dim + c_vol <= 110592 && weight + c_wei <= pallet_capa)
                {

                    location_id = Convert.ToInt32(dataReader["location_id"]);

                    break;

                }


            }
            dataReader.Close();


        }


        public void updateProduct()
        {
            string instruction = "Update Product2 ";
            instruction += " SET location_id = @location_id ";
            instruction += " where product_id = @product_id ";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@location_id", location_id);
            cmd.Parameters.AddWithValue("@product_id", product_id);
            cmd.ExecuteNonQuery();

        }

        public void updateLocation()
        {
            c_vol = dim + c_vol;
            c_wei = weight + c_wei;
            string instruction = "Update Location ";
            instruction += " SET current_volumn = @c_vol, current_weight = @c_wei ";
            instruction += " WHERE location_id = @location_id";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@c_vol", c_vol);
            cmd.Parameters.AddWithValue("@c_wei", c_wei);
            cmd.ExecuteNonQuery();
        }

        //search if the customer exist in database
        private void btnSr_Click_1(object sender, EventArgs e)
        {
            if (con != null)
            {
                //con.Open();
                btnAdd.Enabled = false;
                string instruction = "SELECT client_id,client_phone,client_email,client_address FROM Client2 ";
                if (txtN.Text.Length > 0)

                {
                    instruction += " WHERE client_name = '" + txtN.Text + "'";

                }
                cmd.CommandText = instruction;
                cmd.Connection = con;
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    txtID.Text = dataReader["client_id"].ToString();
                    txtP.Text = dataReader["client_phone"].ToString();
                    txtE.Text = dataReader["client_email"].ToString();
                    txtAd.Text = dataReader["client_address"].ToString();

                }
                dataReader.Close();
                //con.Close();

                if (txtID.Text != null)
                {
                    btnUp.Enabled = true;
                    btnOr.Enabled = true;
                }
            }
        }

        //add new customer info into customer table 
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (con != null)
            {
                btnSr.Enabled = false;

                if (txtID.Text != null)
                {
                    btnUp.Enabled = true;
                    btnOr.Enabled = true;
                }
                btnUp.Enabled = true;
                btnNew.Enabled = true;
                //con.Open();
                cmd.Parameters.Clear();
                string instruction = "INSERT INTO Client2(client_name,client_phone,client_email,client_address) ";
                instruction += " output INSERTED.client_id ";
                instruction += " values(@a,@b,@c,@d) "; // note there is no space within the quotation mark

                cmd.CommandText = instruction;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@a", txtN.Text);
                cmd.Parameters.AddWithValue("@b", txtP.Text);
                cmd.Parameters.AddWithValue("@c", txtE.Text);
                cmd.Parameters.AddWithValue("@d", txtAd.Text);
                //cmd.ExecuteNonQuery();
                int lastID = (int)cmd.ExecuteScalar();
                txtID.Text = lastID.ToString();
                //con.Close();
            }
        }

        //update the infomation from existing customer 
        private void btnUp_Click_1(object sender, EventArgs e)
        {
            if (con != null)
            {
                //con.Open();
                cmd.Parameters.Clear();
                string instruction = "Update Client2 set client_phone = @a, client_email = @b, client_address = @c WHERE client_id = @d ";
                cmd.CommandText = instruction;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@a", txtP.Text);
                cmd.Parameters.AddWithValue("@b", txtE.Text);
                cmd.Parameters.AddWithValue("@c", txtAd.Text);
                cmd.Parameters.AddWithValue("@d", int.Parse(txtID.Text));
                cmd.ExecuteNonQuery();
                //con.Close();
            }
        }

        //generate new order_id of current customer when order button is clicked
        private void btnOr_Click_1(object sender, EventArgs e)
        {
            if (con != null)
            {
                //con.Open();
                cmd.Parameters.Clear();
                string instruction = "INSERT INTO Orders(client_id) ";
                instruction += " output INSERTED.order_id ";
                instruction += " VALUES(@a) ";
                cmd.CommandText = instruction;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@a", int.Parse(txtID.Text));
                //cmd.ExecuteNonQuery();
                order_id = (int)cmd.ExecuteScalar();
                txtOID.Text = order_id.ToString();
                //con.Close();

                Order.Enabled = true;

            }
        }

        //add current product info into database
        private void btnAddP_Click_1(object sender, EventArgs e)
        {
            if (con != null)
            {
                
                cmd.Parameters.Clear();

                if (desCombo.SelectedIndex > -1 && unitCombo.SelectedIndex > -1)
                {
                    //insert into Product2 table
                    insertProduct();
                    //get the location_id to store and update the location_id weight and volumn info and the product2 location info
                    locate();
                    //update the total product storing cost per month
                    Price = ((decimal)dim / 110592) * Pallet_price + Price;
                    Price = Math.Round(Price, 2);

                }
                else
                {
                    MessageBox.Show("please choose the description and unit");
                }

            }
        }

        //new product info to input
        private void btnNew_Click_1(object sender, EventArgs e)
        {
            desCombo.SelectedIndex = -1;
            unitCombo.SelectedIndex = -1;
            txtQu.Clear();
            txtLe.Clear();
            txtWi.Clear();
            txtHe.Clear();
            txtWe.Clear();
            txtEp.Clear();
            txtCI.Clear();
            txtPID.Clear();
            txtNa.Clear();
            product_id = 0;
            dim = 0;
            aisleno = 0;
            weight = 0;
            pallet_capa = 0;
            c_vol = 0;
            c_wei = 0;
            location_id = 0;
            Pallet_price = 0.00m;
        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            if (con != null)
            {
               
                cmd.Parameters.Clear();
                string instruction = "select * from Product2 where order_id = @order_id ";
                cmd.CommandText = instruction;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@order_id", order_id);

                //display the product info into the datagridview
                mcmd.SelectCommand = cmd;
                DataSet ds = new DataSet();
                mcmd.Fill(ds);
                OrderData.DataSource = ds.Tables[0];

                //display the price into price text boxes
                txtPrice.Text = Price.ToString();
                txtTax.Text = Math.Round((Price * 0.13m), 2).ToString();
                txtTp.Text = Math.Round((Price * (1 + 0.13m)), 2).ToString();
                

            }
        }

        //need to improve the delete function, cancel all the order? 
        private void btnCa_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(con);
            mainpage.Show();
            this.Hide();
        }

        //reset all the info to start a new customer
        private void btnRe_Click(object sender, EventArgs e)
        {
            desCombo.SelectedIndex = -1;
            unitCombo.SelectedIndex = -1;
            txtQu.Clear();
            txtLe.Clear();
            txtWi.Clear();
            txtHe.Clear();
            txtWe.Clear();
            txtEp.Clear();
            txtCI.Clear();
            txtPID.Clear();
            txtNa.Clear();
            txtOID.Clear();
            product_id = 0;
            dim = 0;
            aisleno = 0;
            weight = 0;
            pallet_capa = 0;
            c_vol = 0;
            c_wei = 0;
            location_id = 0;
            Pallet_price = 0.00m;
            txtID.Clear();
            txtN.Clear();
            txtE.Clear();
            txtAd.Clear();
            txtP.Clear();
            txtPrice.Clear();
            txtTax.Clear();
            txtTp.Clear();
            OrderData.DataSource = null;
            OrderData.Rows.Clear();
            btnSr.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(con);
            mainpage.Show();
            this.Hide();
        }
    }
}
