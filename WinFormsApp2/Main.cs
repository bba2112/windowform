namespace WinFormsApp2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgressBar pb = new ProgressBar();
            pb.ShowDialog();
            pb = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            messagebox mb = new messagebox();
            mb.ShowDialog();
            mb = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ttsinhvien ttsv = new ttsinhvien();
            ttsv.ShowDialog();
            ttsv = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            treeview tv = new treeview();
            tv.ShowDialog();
            tv = null;
            this.Show();
        }

        private void btntimer_Click(object sender, EventArgs e)
        {
            this.Hide();
            time timer = new time();
            timer.ShowDialog();
            timer = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            stvb STVB = new stvb();
            STVB.ShowDialog();
            STVB = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cau2 c2 = new Cau2();
            c2.ShowDialog();
            c2 = null;
            this.Show();
        }
    }
}