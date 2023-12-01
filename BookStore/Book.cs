using System.Data;
using System.Data.SqlClient;
namespace BookStore
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WhileBookStoreDataBase.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
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
        private void Filter()
        {
            Con.Open();
            string query = "select *from BookTb1 where BCat = '" + CatCbSearchCb.SelectedItem.ToString() + "' ";

            //下面两句配合使用可以批量查询数据
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();

            //创建虚拟数据库
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAutTb.Text == "" || QTyTb.Text == "" || PriceTb.Text == ""
                || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("信息未填写完整，请补充信息！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTb1 values('" + BTitleTb.Text + "','" + BAutTb.Text + "','" + BCatCb.SelectedItem.ToString() + "'," + QTyTb.Text + "," + PriceTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("书籍信息保存成功！！！");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CatCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;
        }

        private void Reset()
        {
            //清空输入框的所有内容
            BTitleTb.Text = "";
            BAutTb.Text = "";
            QTyTb.Text = "";
            PriceTb.Text = "";
            BCatCb.SelectedIndex = -1;

        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int key = 0;
        //本函数用于点击数据行之后在文本框显示信息
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            BAutTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            BCatCb.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            QTyTb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                //捕获第一列数据ID，将值赋给key
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("请选择一条信息！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from BookTb1 where BId = " + key;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("书籍信息删除完成！！！");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAutTb.Text == "" || QTyTb.Text == "" || PriceTb.Text == ""
                 || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("信息未填写完整，请补充信息！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update BookTb1 set BTitle='" + BTitleTb.Text + "', BAuthor='" + BAutTb.Text + "', BCat='" + BCatCb.SelectedItem.ToString() + "',BQty=" + QTyTb.Text + ", BPrice=" + PriceTb.Text + " where BId = " + key;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("书籍信息更新成功！！！");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Book obj = new Book();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Book obj = new Book();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Hide();
        }
    }
}
