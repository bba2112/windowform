namespace WinFormsApp2
{
    partial class Bai1
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
            txtTen = new TextBox();
            txtHocbong = new TextBox();
            cbLop = new ComboBox();
            lvDanhsach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnThem = new Button();
            btnLuu = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 109);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 178);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Học Bổng:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(129, 42);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 34);
            txtTen.TabIndex = 3;
            // 
            // txtHocbong
            // 
            txtHocbong.Location = new Point(134, 175);
            txtHocbong.Multiline = true;
            txtHocbong.Name = "txtHocbong";
            txtHocbong.Size = new Size(125, 34);
            txtHocbong.TabIndex = 4;
            // 
            // cbLop
            // 
            cbLop.FormattingEnabled = true;
            cbLop.Items.AddRange(new object[] { "09CT111", "09CT112", "09CT113" });
            cbLop.Location = new Point(129, 109);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(151, 28);
            cbLop.TabIndex = 5;
            // 
            // lvDanhsach
            // 
            lvDanhsach.AllowDrop = true;
            lvDanhsach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvDanhsach.FullRowSelect = true;
            lvDanhsach.Location = new Point(50, 253);
            lvDanhsach.Name = "lvDanhsach";
            lvDanhsach.Size = new Size(724, 185);
            lvDanhsach.TabIndex = 6;
            lvDanhsach.UseCompatibleStateImageBehavior = false;
            lvDanhsach.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Họ Tên";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Lớp";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Học Bổng";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(407, 179);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(549, 180);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // button1
            // 
            button1.Location = new Point(680, 180);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(lvDanhsach);
            Controls.Add(cbLop);
            Controls.Add(txtHocbong);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTen;
        private TextBox txtHocbong;
        private ComboBox cbLop;
        private ListView lvDanhsach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnThem;
        private Button btnLuu;
        private Button button1;
    }
}