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
    public partial class points : Form
    {
        public points()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-LBL0EKF6\\SQLEXPRESS;Initial Catalog=\"User Info\";Integrated Security=True");


        private void points_Load(object sender, EventArgs e)
        {
            balancelbl.Text = "Balance : " + main.bal;
            cardnumberlbl.Text = "Cardnumber : " + main.cdnum;
            usernamelbl.Text = "Username : " + Login.user;
            fnamelbl.Text = "Welcome back " + main.fname;
            pointslbl.Text = "Points : " + main.pts;
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (main.pts >= 10)
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);
                SqlCommand cmd2 = new SqlCommand("update data set Points = @Points where Username ='" + Login.user + "'", con);
                cmd1.Parameters.AddWithValue("@Balance", main.bal + 1);
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@Points", main.pts - 10);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Transaction Completed");
                main f2 = new main();
                this.Hide();
                f2.Show();
            }
            else
                MessageBox.Show("Insuffient poitns");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (main.pts >= 100)
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);
                SqlCommand cmd2 = new SqlCommand("update data set Points = @Points where Username ='" + Login.user + "'", con);
                cmd1.Parameters.AddWithValue("@Balance", main.bal + 15);
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@Points", main.pts - 100);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Transaction Completed");
                main f2 = new main();
                this.Hide();
                f2.Show();
            }
            else
                MessageBox.Show("Insuffient poitns");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (main.pts >= 200)
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);
                SqlCommand cmd2 = new SqlCommand("update data set Points = @Points where Username ='" + Login.user + "'", con);
                cmd1.Parameters.AddWithValue("@Balance", main.bal + 40);
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@Points", main.pts - 200);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Transaction Completed");
                main f2 = new main();
                this.Hide();
                f2.Show();
            }
            else
                MessageBox.Show("Insuffient poitns");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (main.pts >= 500)
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);
                SqlCommand cmd2 = new SqlCommand("update data set Points = @Points where Username ='" + Login.user + "'", con);
                cmd1.Parameters.AddWithValue("@Balance", main.bal + 100);
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@Points", main.pts - 500);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Transaction Completed");
                main f2 = new main();
                this.Hide();
                f2.Show();
            }
            else
                MessageBox.Show("Insuffient poitns");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (main.pts >= 1000)
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);
                SqlCommand cmd2 = new SqlCommand("update data set Points = @Points where Username ='" + Login.user + "'", con);
                cmd1.Parameters.AddWithValue("@Balance", main.bal + 250);
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@Points", main.pts - 1000);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Transaction Completed");
                main f2 = new main();
                this.Hide();
                f2.Show();
            }
            else
                MessageBox.Show("Insuffient poitns");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (main.pts >= 10000)
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);
                SqlCommand cmd2 = new SqlCommand("update data set Points = @Points where Username ='" + Login.user + "'", con);
                cmd1.Parameters.AddWithValue("@Balance", main.bal + 3000);
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@Points", main.pts - 10000);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Transaction Completed");
                main f2 = new main();
                this.Hide();
                f2.Show();
            }
            else
                MessageBox.Show("Insuffient poitns");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.Show();
        }
    }
}
