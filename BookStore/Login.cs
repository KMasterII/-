using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WhileBookStoreDataBase.mdf;Integrated Security=True;Connect Timeout=30");

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //定义一个全局可用的字符串变量用于存储登录用户的信息
        public static string UserName = "";
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTb1 where UName='" + UNameTb.Text + "'AND UPassword='" + UPassTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                UserName = UNameTb.Text;
                Billing bill = new Billing();
                bill.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("用户名或者密码错误！！！");
            }
            Con.Close();
        }

        private void AdminLbl_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
