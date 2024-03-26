using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Bai4 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        public Bai4()
        {
            InitializeComponent();
            InitializeDrawing();
        }
        private void InitializeDrawing()
        {
            // Sự kiện chuột khi nhấn chuột trái
            this.MouseDown += Bai4_MouseDown;
            // Sự kiện chuột khi di chuyển chuột (vẽ)
            this.MouseMove += Bai4_MouseMove;
            // Sự kiện chuột khi thả chuột trái
            this.MouseUp += Bai4_MouseUp;
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void Bai4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location;
            }
        }

        private void Bai4_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    // Vẽ đường thẳng từ vị trí trước đó đến vị trí hiện tại
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                    // Lưu vị trí hiện tại để sử dụng trong lần vẽ tiếp theo
                    previousPoint = e.Location;
                }
            }
        }

        private void Bai4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }
    }
}
