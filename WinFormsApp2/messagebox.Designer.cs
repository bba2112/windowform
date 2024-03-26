namespace WinFormsApp2
{
    partial class messagebox
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
            txtChuoi = new TextBox();
            lvThongKe = new ListView();
            btnChuanHoa = new Button();
            btnThongKe = new Button();
            btnLuu = new Button();
            cHTuDon = new ColumnHeader();
            cHTanSo = new ColumnHeader();
            SuspendLayout();
            // 
            // txtChuoi
            // 
            txtChuoi.Location = new Point(12, 12);
            txtChuoi.Multiline = true;
            txtChuoi.Name = "txtChuoi";
            txtChuoi.Size = new Size(197, 238);
            txtChuoi.TabIndex = 0;
            txtChuoi.TextChanged += txtChuoi_TextChanged;
            // 
            // lvThongKe
            // 
            lvThongKe.Columns.AddRange(new ColumnHeader[] { cHTuDon, cHTanSo });
            lvThongKe.Location = new Point(375, 12);
            lvThongKe.Name = "lvThongKe";
            lvThongKe.Size = new Size(361, 238);
            lvThongKe.TabIndex = 1;
            lvThongKe.UseCompatibleStateImageBehavior = false;
            lvThongKe.View = View.Details;
            // 
            // btnChuanHoa
            // 
            btnChuanHoa.Location = new Point(12, 318);
            btnChuanHoa.Name = "btnChuanHoa";
            btnChuanHoa.Size = new Size(94, 29);
            btnChuanHoa.TabIndex = 2;
            btnChuanHoa.Text = "Chuẩn Hoá";
            btnChuanHoa.UseVisualStyleBackColor = true;
            btnChuanHoa.Click += btnChuanHoa_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(375, 318);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 29);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(642, 318);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // cHTuDon
            // 
            cHTuDon.Text = "Từ Đơn";
            // 
            // cHTanSo
            // 
            cHTanSo.Text = "Tần Số";
            // 
            // messagebox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLuu);
            Controls.Add(btnThongKe);
            Controls.Add(btnChuanHoa);
            Controls.Add(lvThongKe);
            Controls.Add(txtChuoi);
            Name = "messagebox";
            Text = "messagebox";
            Load += messagebox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtChuoi;
        private ListView lvThongKe;
        private Button btnChuanHoa;
        private Button btnThongKe;
        private Button btnLuu;
        private ColumnHeader cHTuDon;
        private ColumnHeader cHTanSo;
    }
}