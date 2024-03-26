namespace WinFormsApp2
{
    partial class treeview
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
            TreeNode treeNode1 = new TreeNode("Node11");
            TreeNode treeNode2 = new TreeNode("Program Files", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Node12");
            TreeNode treeNode4 = new TreeNode("Users", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("Node13");
            TreeNode treeNode6 = new TreeNode("Windows", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("Node14");
            TreeNode treeNode8 = new TreeNode("Intel", new TreeNode[] { treeNode7 });
            TreeNode treeNode9 = new TreeNode("HeDieuHanh(C:)", new TreeNode[] { treeNode2, treeNode4, treeNode6, treeNode8 });
            TreeNode treeNode10 = new TreeNode("Nhạc");
            TreeNode treeNode11 = new TreeNode("Node15");
            TreeNode treeNode12 = new TreeNode("Phần mềm", new TreeNode[] { treeNode11 });
            TreeNode treeNode13 = new TreeNode("Node16");
            TreeNode treeNode14 = new TreeNode("Phim", new TreeNode[] { treeNode13 });
            TreeNode treeNode15 = new TreeNode("Hình Ảnh");
            TreeNode treeNode16 = new TreeNode("GiaiTri (D:)", new TreeNode[] { treeNode10, treeNode12, treeNode14, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Node17");
            TreeNode treeNode18 = new TreeNode("Công Việc (E:)", new TreeNode[] { treeNode17 });
            tvDanhSach = new TreeView();
            btnHienThi = new Button();
            btnThoat = new Button();
            btnThuGon = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tvDanhSach
            // 
            tvDanhSach.Location = new Point(47, 48);
            tvDanhSach.Name = "tvDanhSach";
            treeNode1.Name = "Node11";
            treeNode1.Text = "Node11";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Program Files";
            treeNode3.Name = "Node12";
            treeNode3.Text = "Node12";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Users";
            treeNode5.Name = "Node13";
            treeNode5.Text = "Node13";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Windows";
            treeNode7.Name = "Node14";
            treeNode7.Text = "Node14";
            treeNode8.Name = "Node5";
            treeNode8.Text = "Intel";
            treeNode9.Name = "Node0";
            treeNode9.Text = "HeDieuHanh(C:)";
            treeNode10.Name = "Node6";
            treeNode10.Text = "Nhạc";
            treeNode11.Name = "Node15";
            treeNode11.Text = "Node15";
            treeNode12.Name = "Node7";
            treeNode12.Text = "Phần mềm";
            treeNode13.Name = "Node16";
            treeNode13.Text = "Node16";
            treeNode14.Name = "Node8";
            treeNode14.Text = "Phim";
            treeNode15.Name = "Node9";
            treeNode15.Text = "Hình Ảnh";
            treeNode16.Name = "Node1";
            treeNode16.Text = "GiaiTri (D:)";
            treeNode17.Name = "Node17";
            treeNode17.Text = "Node17";
            treeNode18.Name = "Node10";
            treeNode18.Text = "Công Việc (E:)";
            tvDanhSach.Nodes.AddRange(new TreeNode[] { treeNode9, treeNode16, treeNode18 });
            tvDanhSach.Size = new Size(723, 276);
            tvDanhSach.TabIndex = 0;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(204, 346);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 1;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(518, 346);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThuGon
            // 
            btnThuGon.Location = new Point(365, 346);
            btnThuGon.Name = "btnThuGon";
            btnThuGon.Size = new Size(94, 29);
            btnThuGon.TabIndex = 3;
            btnThuGon.Text = "Thu Gọn";
            btnThuGon.UseVisualStyleBackColor = true;
            btnThuGon.Click += btnThuGon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "TreeView";
            // 
            // treeview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnThuGon);
            Controls.Add(btnThoat);
            Controls.Add(btnHienThi);
            Controls.Add(tvDanhSach);
            Name = "treeview";
            Text = "treeview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvDanhSach;
        private Button btnHienThi;
        private Button btnThoat;
        private Button btnThuGon;
        private Label label1;
    }
}