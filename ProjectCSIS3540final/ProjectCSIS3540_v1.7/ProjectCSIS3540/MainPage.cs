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
    public partial class MainPage : Form
    {
        SqlConnection con = null;

        public MainPage(SqlConnection conn)
        {
            InitializeComponent();
            con = conn;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }


        private void btnPSearch_Click(object sender, EventArgs e)
        {
            ProductsSearch productssearch = new ProductsSearch(con);
            productssearch.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers(con);
            cust.Show();
            this.Hide();
        }

        private void btnMainCheck_Click(object sender, EventArgs e)
        {
            CheckSpace check = new CheckSpace(con);
            check.Show();
            this.Hide();
        }

        private void btnCI_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn(con);
            checkIn.Show();
            this.Hide();
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            CheckOut checkout = new CheckOut(con);
            checkout.Show();
            this.Hide();
        }

        private void btnMainDC_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();

        }
    }
}
