//using Sql.Data.SqlClient;
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
    public partial class ProductsSearch : Form
    {
        SqlConnection con = null;
        SqlCommand cmd;
        SqlDataAdapter mcmd;

        public ProductsSearch(SqlConnection conn)
        {
            InitializeComponent();
            con = conn;
            cmd = new SqlCommand();
            mcmd = new SqlDataAdapter();
            
        }

        private void ProductsSearch_Load(object sender, EventArgs e)
        {
            //may have issues for where 1?
            WindowState = FormWindowState.Maximized;
            string instruction = "SELECT * FROM Product2 ";
            DisplayTables(instruction, dgvPS, "Storage");
            //populate the description list into the combo box
            populateCategory();

        }

        private void populateCategory()
        {
            string instruction = "SELECT description FROM Product2 GROUP BY description ORDER BY description ASC";
            display(instruction, cbbPSCat);
        }

        //read the discription data from database table and write it into the combobox
        private void display(string instruction, ComboBox destBox)
        {

            cmd.CommandText = instruction;
            destBox.Items.Clear();
            destBox.Text = "";
            SqlDataReader dataReader = cmd.ExecuteReader(); // execute the given sql instruction
            while (dataReader.Read())
            {
                destBox.Items.Add(dataReader[0]);
            }
            dataReader.Close();
            // this would trigger deptCombo SelectedIndex event
            if (destBox.Items.Count > 0)
                destBox.SelectedIndex = 0;

        }

        //make the checkin and checkout function restored if the login is true and disabled if the login is off
        private void btnPSBack_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(con);
            mainpage.Show();
            this.Hide();
            if(statusSer() == "1")
            {
                mainpage.btnCI.Enabled = true;
                mainpage.btnCO.Enabled = true;
            }
            else
            {
                mainpage.btnCI.Enabled = false;
                mainpage.btnCO.Enabled = false;
            }
            
        }

        //detect the user is login or off status
        public string statusSer()
        {
            string instruction = "select status from status where id = 1 ";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            return cmd.ExecuteScalar().ToString();
        }

        private void btnPSExit_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }

      
        //reload the products results when the description combox selection is changed
        private void cbbPSCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string description = cbbPSCat.Text;
            if(description != "")
            {
                string instruction = "Select * from Product2 ";
                instruction += " Where description = '" + description + "'";
                DisplayTables(instruction, dgvPS, "Product2");
            }
        }
        

        //reload the products result when the product_id textbox is changed
        private void txbPSSearch_TextChanged(object sender, EventArgs e)
        {
            string id = txbPSSearch.Text;
            if (id != "")
            {
                string instruction = "Select * from Product2 ";
                instruction += " Where product_id = '" + id + "'";
                DisplayTables(instruction, dgvPS, "Product2");
            }
        }

        public void DisplayTables(string instruction, DataGridView dgv, string tableName)
        {

            cmd.CommandText = instruction;
            cmd.Connection = con;
            mcmd.SelectCommand = cmd;
            DataSet ds = new DataSet();
            mcmd.Fill(ds, tableName);
            dgv.DataSource = ds.Tables[tableName];
            mcmd.Dispose();
        }
    }
}
