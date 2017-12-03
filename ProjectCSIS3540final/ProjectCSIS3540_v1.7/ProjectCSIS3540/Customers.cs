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
    public partial class Customers : Form
    {
        SqlConnection con = null;
        SqlCommand cmd;
        SqlDataAdapter mcmd;

        public Customers(SqlConnection conn)
        {
            InitializeComponent();
            con = conn;
            cmd = new SqlCommand();
            mcmd = new SqlDataAdapter();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            string instruction = "Select * from Client2";
            DisplayTables(instruction, dgvPS, "Storage");
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

        /*
        private void btnCDelete_Click(object sender, EventArgs e)
        {
            deleteRecord();
        }
        */

        private void btnCBack_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(con);
            mainpage.Show();
            this.Hide();
            //if login = true, checkin and checkout function is restored
            if (statusSer() == "1")
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

        //verify the status of login 
        public string statusSer()
        {
            string instruction = "select status from status where id = 1 ";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            return cmd.ExecuteScalar().ToString();
        }

        private void btnCExit_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }

        //search by customer_id
        private void btnPSSearch_Click(object sender, EventArgs e)
        {
            string id = txbPSSearch.Text;
            string instruction = "Select * from Client2 Where client_id = '" + id + "'" ;
            DisplayTables(instruction, dgvPS, "Client2");
        }

        //search by customer_name
        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            string name = txbNameSe.Text;
            string instruction = "Select * from Client2 Where client_name = '" + name + "'";
            DisplayTables(instruction, dgvPS, "Client2");
        }

       
        /*
        private void deleteRecord()
        {
            if (dgvPS.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvPS.SelectedRows[0].Index;

                // gets the RowID from the first column in the grid
                int rowID = int.Parse(dgvPS[0, selectedIndex].Value.ToString());

                string query = "DELETE FROM Client2 WHERE RowID = @RowID";
                cmd.Connection = Sqlconnection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                // your code for deleting it from the database

                // then your code for refreshing the DataGridView
            }
        }
        */
    }
}
