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
    public partial class sendmoney : Form
    {
        public sendmoney()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-LBL0EKF6\\SQLEXPRESS;Initial Catalog=\"User Info\";Integrated Security=True");

        public static decimal bal2;

        private void getbalance(String cdn)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM data WHERE Cardnumber ='" + cdn + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            bal2 = decimal.Parse(dt.Rows[0][0].ToString());
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

        private void sendmoney_Load(object sender, EventArgs e)
        {
            balancelbl.Text = "Balance : " + main.bal;
            cardnumberlbl.Text = "Cardnumber : " + main.cdnum;
            usernamelbl.Text = "Username : " + Login.user;
            fnamelbl.Text = "Welcome back " + main.fname;
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

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM data WHERE Cardnumber ='" + textBox1.Text +"'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (textBox1.Text == main.cdnum)
            {
                MessageBox.Show("Cant send money to used account");
                con.Close();
                textBox1.Text = "";
            }
            else
            {
                if (dt.Rows.Count == 1)
                {
                    if (main.bal >= decimal.Parse(textBox2.Text))
                    {

                        SqlCommand cmd1 = new SqlCommand("update data set Balance = @Balance where Username ='" + Login.user + "'", con);
                        SqlCommand cmd2 = new SqlCommand("update data set Balance = @Balance where Cardnumber ='" + textBox1.Text + "'", con);
                        SqlCommand cmd3 = new SqlCommand("update data set Points = @Points where Username ='" + Login.user + "'", con);

                        cmd1.Parameters.AddWithValue("@Balance", main.bal - decimal.Parse(textBox2.Text));
                        cmd1.ExecuteNonQuery();

                        getbalance(textBox1.Text);
                        cmd2.Parameters.AddWithValue("@Balance", bal2 + decimal.Parse(textBox2.Text));
                        cmd2.ExecuteNonQuery();

                        cmd3.Parameters.AddWithValue("@points", main.pts + int.Parse(textBox2.Text) * 0.1);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Transaction Completed");
                        main f2 = new main();
                        this.Hide();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid withdraw amount");
                        textBox2.Text = "";
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Cardnumber");
                    textBox1.Text = "";
                    con.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}