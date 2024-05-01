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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-LBL0EKF6\\SQLEXPRESS;Initial Catalog=\"User Info\";Integrated Security=True");


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public static String user;
        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM data WHERE Username ='" + cdtxt.Text + "' AND Password ='" + passwordtxt.Text + "'", con);
            

            DataTable dt = new DataTable(); 
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                user = cdtxt.Text;
                main f1 = new main();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                cdtxt.Text = "";
                passwordtxt.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            signup f2 = new signup();
            this.Hide();
            f2.Show();
        }

        private void cdtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
