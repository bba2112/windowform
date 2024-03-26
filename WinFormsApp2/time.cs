using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class time : Form
    {

        public time()
        {
            InitializeComponent();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += timer1_Tick;

            //Bắt đầu đồng hồ khi Form được load
            timer.Start();
        }

        private void time_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Hiển thị thời gian lên Label
            lbValue.Text = currentTime.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
