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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-LBL0EKF6\\SQLEXPRESS;Initial Catalog=\"User Info\";Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            this.Hide();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            var r = generator.Next(10000000, 100000000);
            string s = r.ToString("00000000");

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into data (Firstname,Lastname,Username,Password,NationalID,Mobile,Cardnumber,Balance,Points) values('" + fnametxt.Text + "','" + lnametxt.Text + "','" + usernametxt.Text + "','" + passtxt.Text + "','" + nidtxt.Text + "','" + mobiletxt.Text + "','" + s + "','"+0+"','"+0+"')", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Your card number is" + s);

            con.Close();

            Login f1 = new Login();
            this.Hide();
            f1.Show();
        }
    }
}
