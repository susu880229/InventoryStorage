using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
//using Sql.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//login username: darren0
//      password: 123456
//team members: ling su 
//              Mansi Mansi
//              Concepcion Darren
//              Kozlov Roman
//              Mendes-Ferreira-Guariglia Joao-Lucas
namespace ProjectCSIS3540
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        //DBConnect dbInfo;
        string connString;
        SqlCommand cmd;
        public bool login = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dbInfo = new DBConnect();
            //only need to know the connectionstring when connect to the database
            //use @ to make the normally escape sequce letter is ingored such as \
            connString = @"Data Source=SUSU\SQLEXPRESS;Initial Catalog=public_storage;Integrated Security=True";
            cmd = new SqlCommand();
            connect();
        }

        public void connect()
        {
            con = new SqlConnection(connString);
            try
            {
                con.Open();
                this.Text = " [Connected]";
            }
            catch (Exception e)
            {
                this.Text = "Problem";
                MessageBox.Show(e.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string instruction = "SELECT 1 FROM Login ";
            instruction += " WHERE Username = '" + txbUser.Text + "' AND Password = '" + txbPassw.Text + "'";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            SqlDataReader dataReader = cmd.ExecuteReader();
            //there are matching username and password in the database, log in.
            if (dataReader.Read())
            {
                MainPage mainpage = new MainPage(con);
                mainpage.Show();
                mainpage.btnCI.Enabled = true;
                mainpage.btnCO.Enabled = true;
                this.Hide();
                login = true;
               
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
                login = false;
            }
            dataReader.Close();
            updateSta();

        }

        private void btnLoginGuest_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(con);
            mainpage.Show();
            mainpage.btnCI.Enabled = false;
            mainpage.btnCO.Enabled = false;
            this.Hide();
            login = false;
            updateSta();
        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
          

        }

        public void updateSta()
        {
            //may have problem due to login is boolean in client, and bit in server?
            string instruction = "update status SET status = @login WHERE id = 1 ";
            cmd.CommandText = instruction;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@login", login);
            cmd.ExecuteNonQuery();

        }
        
    }
}
