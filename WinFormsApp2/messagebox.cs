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
    public partial class messagebox : Form
    {
        public messagebox()
        {
            InitializeComponent();
        }

        private void txtChuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void messagebox_Load(object sender, EventArgs e)
        {
            // Hiển thị MessageBox khi Form được load
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục Load Form?", "Bùi Bảo Anh - 22", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                this.Close(); // Đóng Form nếu người dùng chọn No
            }
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            // Chuẩn hóa chuỗi
            string chuoiNhap = txtChuoi.Text.Trim(); // Loại bỏ khoảng trắng thừa
            chuoiNhap = ChuoiChuanHoa(chuoiNhap); // Chuẩn hóa chuỗi
            txtChuoi.Text = chuoiNhap; // Hiển thị chuỗi đã chuẩn hóa

            // Thống kê tần số xuất hiện của từ đơn và hiển thị trên ListView
            ThongKeTanso(chuoiNhap);
        }
        private string ChuoiChuanHoa(string chuoi)
        {
            // Chuẩn hóa chuỗi: loại bỏ khoảng trắng thừa và định dạng dấu câu
            return chuoi; 
        }
        private void ThongKeTanso(string chuoi)
        {
            // Thống kê tần số xuất hiện của từ đơn và hiển thị trên ListView
            // Viết logic của bạn ở đây
            // Ví dụ tạo một danh sách từ đơn và thêm vào ListView:
            List<string> danhSachTuDon = chuoi.Split(' ').ToList();
            var thongKe = danhSachTuDon.GroupBy(tu => tu.ToLower()).Select(group => new
            {
                Tu = group.Key,
                TanSo = group.Count()
            }).ToList();

            // Xóa tất cả các mục trong ListView trước khi thêm mới
            lvThongKe.Items.Clear();

            // Thêm các mục vào ListView
            foreach (var item in thongKe)
            {
                ListViewItem lvItem = new ListViewItem(item.Tu);
                lvItem.SubItems.Add(item.TanSo.ToString());
                lvThongKe.Items.Add(lvItem);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox thông báo lưu thành công và thoát khỏi ứng dụng
            MessageBox.Show("Đã lưu thành công");
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeTanso(txtChuoi.Text);
        }
    }
}
