using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class stvb : Form
    {
        DateTime dt = new DateTime();
        public stvb()
        {
            InitializeComponent();
            InitializeMenu();
        }
        private void InitializeMenu()
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiNgay_Click(object sender, EventArgs e)
        {
            txtChuoi.AppendText(DateTime.Now.ToString("dd/MM/yyyy") + Environment.NewLine);
        }

        private void tsmiGio_Click(object sender, EventArgs e)
        {
            txtChuoi.AppendText(DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtChuoi.Font = fontDialog.Font;
            }
        }

        private void tsmiColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtChuoi.ForeColor = colorDialog.Color;
            }
        }

        private void tsmiAlign_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAlignleft_Click(object sender, EventArgs e)
        {
            txtChuoi.TextAlign = HorizontalAlignment.Left;
        }

        private void tsmiRight_Click(object sender, EventArgs e)
        {
            txtChuoi.TextAlign = HorizontalAlignment.Right;
        }

        private void tsmiCenter_Click(object sender, EventArgs e)
        {
            txtChuoi.TextAlign = HorizontalAlignment.Center;
        }

        private void tsmicook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiNgay_Click_1(object sender, EventArgs e)
        {
            txtChuoi.AppendText(DateTime.Now.ToString("dd/MM/yyyy") + Environment.NewLine);
        }

        private void tsmiGio_Click_1(object sender, EventArgs e)
        {
            txtChuoi.AppendText(DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine);
        }

        private void tsmiFont_Click_1(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtChuoi.Font = fontDialog.Font;
            }
        }

        private void tsmiColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtChuoi.ForeColor = colorDialog.Color;
            }
        }

        private void tsmiAlignleft_Click_1(object sender, EventArgs e)
        {
            txtChuoi.TextAlign = HorizontalAlignment.Left;
        }

        private void tsmiRight_Click_1(object sender, EventArgs e)
        {
            txtChuoi.TextAlign = HorizontalAlignment.Right;
        }

        private void tsmiCenter_Click_1(object sender, EventArgs e)
        {
            txtChuoi.TextAlign = HorizontalAlignment.Center;
        }
    }
}
