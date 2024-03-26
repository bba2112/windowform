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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            txtNam.Text = (DTP1.Value.Year).ToString();
            txtNgay.Text = (DTP1.Value.Day).ToString();
            txtThang.Text = (DTP1.Value.Month).ToString();
            txtNgayhientai.Text = DTP1.Value.ToString();
            txtThu.Text = (DTP1.Value.DayOfWeek).ToString();
            txtNgaycuanam.Text = (DTP1.Value.DayOfYear).ToString();

        }

        private void DTP1_ValueChanged(object sender, EventArgs e)
        {
            txtNam.Text = (DTP1.Value.Year).ToString();
            txtNgay.Text = (DTP1.Value.Day).ToString();
            txtThang.Text = (DTP1.Value.Month).ToString();
            txtNgayhientai.Text = DTP1.Value.ToString();
            txtThu.Text = (DTP1.Value.DayOfWeek).ToString();
            txtNgaycuanam.Text = (DTP1.Value.DayOfYear).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
