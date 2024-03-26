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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các thông tin nhập vào
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtHocbong.Text) || string.IsNullOrWhiteSpace(cbLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (Họ tên, Học bổng và Chọn lớp).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm thông tin vào ListView
            ListViewItem item = new ListViewItem(txtTen.Text);
            item.SubItems.Add(txtHocbong.Text);
            item.SubItems.Add(cbLop.Text);
            lvDanhsach.Items.Add(item);

            // Xóa nội dung các control sau khi thêm thành công
            txtTen.Clear();
            txtHocbong.Clear();
            cbLop.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có sinh viên nào trong ListView
            if (lvDanhsach.Items.Count == 0)
            {
                MessageBox.Show("Không có sinh viên nào để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận việc lưu danh sách sinh viên
            DialogResult result = MessageBox.Show("Bạn có muốn lưu danh sách sinh viên vào tập tin không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Tạo hoặc mở tập tin để lưu danh sách sinh viên
                    using (StreamWriter writer = new StreamWriter("DanhSachSinhVien.txt"))           
                    {                     
                        foreach (ListViewItem item in lvDanhsach.Items)
                        {
                            writer.WriteLine($"{item.SubItems[0].Text}, {item.SubItems[1].Text}, {item.SubItems[2].Text}");
                        }
                    }
                    

                    MessageBox.Show("Đã lưu danh sách sinh viên vào tập tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi lưu tập tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

