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
    public partial class CheckSpace : Form
    {
        SqlConnection con = null;
        SqlCommand cmd;
        SqlDataAdapter mcmd;

        public CheckSpace(SqlConnection conn)
        {
            InitializeComponent();
            con = conn;
            cmd = new SqlCommand();
            mcmd = new SqlDataAdapter();
        }

        

        private void btnSBack_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(con);
            mainpage.Show();
            this.Hide();
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
        public string statusSer()
        {
            
            string instruction = "select status from status where id = 1 ";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            return cmd.ExecuteScalar().ToString();
        }
        private void btnSExit_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }

        private void CheckSpace_Load(object sender, EventArgs e)
        {
            string instruction = "Select Pallet_id as Pallet_ID, Pallet_capacity as Capacity, Pallet_price as Price, asile_id as Aisle_ID, current_volumn as Volume, current_weight as Weight from Pallet";
            DisplayTables(instruction, dgv, "Storage");
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
