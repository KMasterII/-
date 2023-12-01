namespace BookStore
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 5;
            Myprogress.Value = startpos;
            PercentageLbl.Text = startpos + "%";
            if(Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void PercentageLbl_Click(object sender, EventArgs e)
        {

        }
    }
}