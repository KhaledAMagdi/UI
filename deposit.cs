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

namespace UI
{
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-LBL0EKF6\\SQLEXPRESS;Initial Catalog=\"User Info\";Integrated Security=True");


        private void homebtn_Click(object sender, EventArgs e)
        {
            main f = new main();
            this.Close();
            f.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);

            
                cmd.Parameters.AddWithValue("@Balance", main.bal + decimal.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Transaction Completed");
                main f2 = new main();
                this.Hide();
                f2.Show();
        }


        private void pointsbtn_Click(object sender, EventArgs e)
        {
            points f = new points();
            this.Close();
            f.Show();
        }

        private void smoneybtn_Click(object sender, EventArgs e)
        {
            sendmoney f = new sendmoney();
            this.Close();
            f.Show();
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            deposit f = new deposit();
            this.Close();
            f.Show();
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            withdraw f = new withdraw();
            this.Close();
            f.Show();
        }

        private void fastcashbtn_Click(object sender, EventArgs e)
        {
            fastcash f = new fastcash();
            this.Close();
            f.Show();
        }

        private void balancelbl_Click(object sender, EventArgs e)
        {

        }

        private void deposit_Load(object sender, EventArgs e)
        {
            balancelbl.Text = "Balance : " + main.bal;
            cardnumberlbl.Text = "Cardnumber : " + main.cdnum;
            usernamelbl.Text = "Username : " + Login.user;
            fnamelbl.Text = "Welcome back " + main.fname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
