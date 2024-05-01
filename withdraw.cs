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
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-LBL0EKF6\\SQLEXPRESS;Initial Catalog=\"User Info\";Integrated Security=True");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void balancelbl_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (main.bal >= decimal.Parse(textBox1.Text))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);
                cmd.Parameters.AddWithValue("@Balance", main.bal - decimal.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Transaction Completed");
                main f2 = new main();
                this.Hide();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid withdraw amount");
                textBox1.Text = "";
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            main f = new main();
            this.Close();
            f.Show();
        }

        private void withdraw_Load(object sender, EventArgs e)
        {
            balancelbl.Text = "Balance : " + main.bal;
            cardnumberlbl.Text = "Cardnumber : " + main.cdnum;
            usernamelbl.Text = "Username : " + Login.user;
            fnamelbl.Text = "Welcome back " + main.fname;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void fastcashbtn_Click_1(object sender, EventArgs e)
        {
            fastcash f = new fastcash();
            this.Close();
            f.Show();
        }

        private void withdrawbtn_Click_1(object sender, EventArgs e)
        {
            withdraw f = new withdraw();
            this.Close();
            f.Show();
        }

        private void depositbtn_Click_1(object sender, EventArgs e)
        {
            deposit f = new deposit();
            this.Close();
            f.Show();
        }

        private void smoneybtn_Click_1(object sender, EventArgs e)
        {
            sendmoney f = new sendmoney();
            this.Close();
            f.Show();
        }

        private void pointsbtn_Click_1(object sender, EventArgs e)
        {
            points f = new points();
            this.Close();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.Show();
        }
    }
}