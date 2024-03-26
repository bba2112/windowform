using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ttsinhvien : Form
    {
        public ttsinhvien()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra ngày sinh
            if (!KiemTraNgaySinh(txtNgaySinh.Text))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập lại theo định dạng ngày/tháng/năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra điểm trung bình
            if (!KiemTraDiemTrungBinh(txtDiemTrungBinh.Text))
            {
                MessageBox.Show("Điểm trung bình không hợp lệ. Vui lòng chỉ nhập số hoặc số thập phân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Nếu đúng hết
            else if (txtNgaySinh != null && txtDiemTrungBinh != null)
            {
                MessageBox.Show("Bạn đã đăng ký thành công");
            }
        }
        private bool KiemTraNgaySinh(string ngaySinh)
        {
            // Kiểm tra định dạng ngày sinh dd/mm/yyyy
            DateTime tempDate;
            return DateTime.TryParseExact(ngaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tempDate);
        }

        private bool KiemTraDiemTrungBinh(string diemTrungBinh)
        {
            // Kiểm tra điểm trung bình là số
            double tempScore;
            return double.TryParse(diemTrungBinh, out tempScore);
        }
        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
