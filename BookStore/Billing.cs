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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WhileBookStoreDataBase.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()//将数据库的内容展示在表上
        {
            Con.Open();
            string query = "select *from BookTb1";

            //下面两句配合使用可以批量查询数据
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();

            //创建虚拟数据库
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void UpdateBook()
        {
            int newAmount = stock - Convert.ToInt32(AmoutTb.Text);
            try
            {
                Con.Open();
                string query = "update BookTb1 set BQty=" + newAmount + " where BId = " + key;
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加购物车成功！！！");
                Con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int n = 0, GrdTotal = 0;
        private void AddtoBillBtn_Click(object sender, EventArgs e)
        {
            if (AmoutTb.Text == "" || Convert.ToInt32(AmoutTb.Text) > stock)
            {
                MessageBox.Show("库存不足！！！");
            }
            else
            {
                int total = Convert.ToInt32(AmoutTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = ++n;
                newRow.Cells[1].Value = BTitleTb.Text;
                newRow.Cells[2].Value = PriceTb.Text;
                newRow.Cells[3].Value = AmoutTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                UpdateBook();
                GrdTotal = GrdTotal + total;
                TotalLbl.Text = GrdTotal + "元";
            }
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int key = 0, stock = 0;

        private void PrintBtn_Click(object sender, EventArgs e)
        {
           
            if (BillDGV.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("请添加宝贝到购物车~~~");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTb1 values('" + UserNameLbl.Text + "'," + GrdTotal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("成功记录订单信息！");
                    Con.Close();    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        int prodid, prodqty, prodprice, tottal, pos = 80;

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = Login.UserName;
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("小白书店", new Font("幼圆", 15, FontStyle.Bold), Brushes.Red, new Point(100,20));
            e.Graphics.DrawString("编号\t产品\t价格\t数量\t总计", new Font("幼圆", 10, FontStyle.Bold), Brushes.Red, new Point(26, 65));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column7"].Value);
                prodname = "" + row.Cells["Column8"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column9"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column10"].Value);
                tottal = Convert.ToInt32(row.Cells["Column11"].Value);
                e.Graphics.DrawString(prodid + "\t", new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString(prodname + "\t", new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString(prodprice + "\t", new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString(prodqty + "\t", new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString(tottal + "", new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos += 20;
            }
            e.Graphics.DrawString("订单总额：¥" + GrdTotal, new Font("幼圆", 12, FontStyle.Bold), Brushes.Crimson, new Point(0, pos + 50));
            e.Graphics.DrawString("****************小白书店****************", new Font("幼圆", 10, FontStyle.Bold), Brushes.Crimson, new Point(0, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            AmoutTb.Text = "";

            if (BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                //捕获第一列数据ID，将值赋给key
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());

                stock = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void RestBtn_Click(object sender, EventArgs e)
        {
            BTitleTb.Text = "";
            AmoutTb.Text = "";
            PriceTb.Text = "";
        }
    }
}
