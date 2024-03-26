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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void cBNghenhac_CheckedChanged(object sender, EventArgs e)
        {
            //if (cBNghenhac = checked)
            //    {
            //    gBSothich.
            //    }
        }

        private void btnSothich_Click(object sender, EventArgs e)
        {
            string soThich = "";

            if (cBNghenhac.Checked)
            {
                soThich += "- Nghe Nhạc\n";
            }
            if (cBXemphim.Checked)
            {
                soThich += "- Xem Phim\n";
            }
            if (cBChoithethao.Checked)
            {
                soThich += "- Chơi Thể thao\n";
            }
            if (cBDimuasam.Checked)
            {
                soThich += "- Đi Mua Sắm\n";
            }
            if (cBDidulich.Checked)
            {
                soThich += "- Đi du lịch\n";
            }

            if (string.IsNullOrEmpty(soThich))
            {
                MessageBox.Show("Bạn chưa chọn sở thích nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sở thích của bạn:\n" + soThich, "Sở thích", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMaubanthich_Click(object sender, EventArgs e)
        {
            string Mauthich = "";

            if (rBDo.Checked)
            {
                Mauthich += "- Đỏ\n";
            }
            if (rBTrang.Checked)
            {
                Mauthich += "- Trắng\n";
            }
            if (rBVang.Checked)
            {
                Mauthich += "- Vàng\n";
            }
            if (rBHong.Checked)
            {
                Mauthich += "- Hồng\n";
            }
            if (rBTim.Checked)
            {
                Mauthich += "- Tím\n";
            }



            if (string.IsNullOrEmpty(Mauthich))
            {
                MessageBox.Show("Bạn chưa chọn màu thích nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sở thích của bạn:\n" + Mauthich, "Sở thích", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
