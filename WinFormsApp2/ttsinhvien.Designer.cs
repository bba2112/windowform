namespace WinFormsApp2
{
    partial class ttsinhvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            txtDiemTrungBinh = new TextBox();
            btnDangKy = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(-4, 46);
            label1.Name = "label1";
            label1.Size = new Size(831, 57);
            label1.TabIndex = 0;
            label1.Text = "ErrorProvider";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 197);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 272);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 337);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 3;
            label4.Text = "Điểm Trung Bình:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(117, 197);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(509, 27);
            txtHoTen.TabIndex = 4;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(137, 272);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(509, 27);
            txtNgaySinh.TabIndex = 5;
            // 
            // txtDiemTrungBinh
            // 
            txtDiemTrungBinh.Location = new Point(180, 330);
            txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            txtDiemTrungBinh.Size = new Size(509, 27);
            txtDiemTrungBinh.TabIndex = 6;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(180, 426);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(532, 426);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // ttsinhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 502);
            Controls.Add(btnThoat);
            Controls.Add(btnDangKy);
            Controls.Add(txtDiemTrungBinh);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ttsinhvien";
            Text = "ttsinhvien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtHoTen;
        private TextBox txtNgaySinh;
        private TextBox txtDiemTrungBinh;
        private Button btnDangKy;
        private Button btnThoat;
    }
}