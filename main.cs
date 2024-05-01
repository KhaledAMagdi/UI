using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UI
{
    public abstract class Printa
    {
        public abstract void printall();

        public virtual void showpass()
        {
            MessageBox.Show("Password");
        }
    }
    public class Userinfo : Printa
    {
        public string firstname { get; set; } 
        public string username { get; set; }
        public string Cardnumber { get; set; }
        public string Balance { get; set; }
        public string Points { get; set; }
        public string pass { get; set; }

        public Userinfo(string firstname,string username,string Cardnumber, string Balance, string Points,string pass)
        {
            this.firstname = firstname;
            this.username = username;
            this.Cardnumber = Cardnumber;
            this.Balance = Balance;
            this.Points = Points;
            this.pass = pass;
        }

        public override void printall()
        {
           MessageBox.Show(""+firstname+" \n"+username+"\n"+Cardnumber+"\n"+Balance+"\n"+Points);
        }

        public override void showpass()
        {
            MessageBox.Show("");
        }

    }

    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-LBL0EKF6\\SQLEXPRESS;Initial Catalog=\"User Info\";Integrated Security=True");

        public static decimal bal;

        private static string passw;

        private void getpass()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Password FROM data WHERE Username ='" + Login.user + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            passw = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM data WHERE Username ='" + Login.user + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            bal = decimal.Parse(dt.Rows[0][0].ToString());
            balancelbl.Text = "Balance : " + dt.Rows[0][0].ToString() + "$";

            con.Close();
        }

        public static String cdnum;

        private void getcdnum()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Cardnumber FROM data WHERE Username ='" + Login.user + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cdnum = dt.Rows[0][0].ToString();
            cardnumberlbl.Text = "Cardnumber : " + dt.Rows[0][0].ToString();

            con.Close();
        }

        public static int pts;

        private void getpts()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Points FROM data WHERE Username ='" + Login.user + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            pts = int.Parse(dt.Rows[0][0].ToString());
            pointslbl.Text = "Points : " + dt.Rows[0][0].ToString();

            con.Close();
        }

        public static String fname;

        private void getfname()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Firstname FROM data WHERE Username ='" + Login.user + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            fname = (dt.Rows[0][0].ToString());
            fnamelbl.Text = "Welcome back " + dt.Rows[0][0].ToString();

            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
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

        private void main_Load(object sender, EventArgs e)
        {
            getbalance();
            getcdnum();
            getpts();
            getfname();
            usernamelbl.Text = "Username : " + Login.user;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cardnumberlbl_Click(object sender, EventArgs e)
        {
        }

        private void balancelbl_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.Show();
        }

        private void pointslbl_Click(object sender, EventArgs e)
        {
        }

        Userinfo current = new Userinfo(fname, Login.user, cdnum, bal.ToString("0000"), pts.ToString("0000"),passw);

    }
}