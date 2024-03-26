namespace WinFormsApp2
{
    partial class Bai2
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
            gBSothich = new GroupBox();
            cBDidulich = new CheckBox();
            cBXemphim = new CheckBox();
            cBDimuasam = new CheckBox();
            cBChoithethao = new CheckBox();
            cBNghenhac = new CheckBox();
            gBMauthich = new GroupBox();
            rBTim = new RadioButton();
            rBHong = new RadioButton();
            rBVang = new RadioButton();
            rBTrang = new RadioButton();
            rBDo = new RadioButton();
            btnSothich = new Button();
            btnMaubanthich = new Button();
            button1 = new Button();
            gBSothich.SuspendLayout();
            gBMauthich.SuspendLayout();
            SuspendLayout();
            // 
            // gBSothich
            // 
            gBSothich.Controls.Add(cBDidulich);
            gBSothich.Controls.Add(cBXemphim);
            gBSothich.Controls.Add(cBDimuasam);
            gBSothich.Controls.Add(cBChoithethao);
            gBSothich.Controls.Add(cBNghenhac);
            gBSothich.Location = new Point(95, 12);
            gBSothich.Name = "gBSothich";
            gBSothich.Size = new Size(239, 321);
            gBSothich.TabIndex = 0;
            gBSothich.TabStop = false;
            gBSothich.Text = "Sở thích của bạn";
            // 
            // cBDidulich
            // 
            cBDidulich.AutoSize = true;
            cBDidulich.Location = new Point(6, 255);
            cBDidulich.Name = "cBDidulich";
            cBDidulich.Size = new Size(94, 24);
            cBDidulich.TabIndex = 4;
            cBDidulich.Text = "Đi du lịch";
            cBDidulich.UseVisualStyleBackColor = true;
            // 
            // cBXemphim
            // 
            cBXemphim.AutoSize = true;
            cBXemphim.Location = new Point(6, 96);
            cBXemphim.Name = "cBXemphim";
            cBXemphim.Size = new Size(98, 24);
            cBXemphim.TabIndex = 3;
            cBXemphim.Text = "Xem Phim";
            cBXemphim.UseVisualStyleBackColor = true;
            // 
            // cBDimuasam
            // 
            cBDimuasam.AutoSize = true;
            cBDimuasam.Location = new Point(6, 206);
            cBDimuasam.Name = "cBDimuasam";
            cBDimuasam.Size = new Size(110, 24);
            cBDimuasam.TabIndex = 2;
            cBDimuasam.Text = "Đi mua sắm";
            cBDimuasam.UseVisualStyleBackColor = true;
            // 
            // cBChoithethao
            // 
            cBChoithethao.AutoSize = true;
            cBChoithethao.Location = new Point(6, 151);
            cBChoithethao.Name = "cBChoithethao";
            cBChoithethao.Size = new Size(126, 24);
            cBChoithethao.TabIndex = 1;
            cBChoithethao.Text = "Chơi Thể Thao";
            cBChoithethao.UseVisualStyleBackColor = true;
            // 
            // cBNghenhac
            // 
            cBNghenhac.AutoSize = true;
            cBNghenhac.Location = new Point(6, 42);
            cBNghenhac.Name = "cBNghenhac";
            cBNghenhac.Size = new Size(105, 24);
            cBNghenhac.TabIndex = 0;
            cBNghenhac.Text = "Nghe Nhạc";
            cBNghenhac.UseVisualStyleBackColor = true;
            cBNghenhac.CheckedChanged += cBNghenhac_CheckedChanged;
            // 
            // gBMauthich
            // 
            gBMauthich.Controls.Add(rBTim);
            gBMauthich.Controls.Add(rBHong);
            gBMauthich.Controls.Add(rBVang);
            gBMauthich.Controls.Add(rBTrang);
            gBMauthich.Controls.Add(rBDo);
            gBMauthich.Location = new Point(472, 12);
            gBMauthich.Name = "gBMauthich";
            gBMauthich.Size = new Size(250, 321);
            gBMauthich.TabIndex = 1;
            gBMauthich.TabStop = false;
            gBMauthich.Text = "Màu bạn thích";
            // 
            // rBTim
            // 
            rBTim.AutoSize = true;
            rBTim.Location = new Point(6, 255);
            rBTim.Name = "rBTim";
            rBTim.Size = new Size(55, 24);
            rBTim.TabIndex = 4;
            rBTim.TabStop = true;
            rBTim.Text = "Tim";
            rBTim.UseVisualStyleBackColor = true;
            // 
            // rBHong
            // 
            rBHong.AutoSize = true;
            rBHong.Location = new Point(6, 205);
            rBHong.Name = "rBHong";
            rBHong.Size = new Size(67, 24);
            rBHong.TabIndex = 3;
            rBHong.TabStop = true;
            rBHong.Text = "Hồng";
            rBHong.UseVisualStyleBackColor = true;
            // 
            // rBVang
            // 
            rBVang.AutoSize = true;
            rBVang.Location = new Point(6, 150);
            rBVang.Name = "rBVang";
            rBVang.Size = new Size(63, 24);
            rBVang.TabIndex = 2;
            rBVang.TabStop = true;
            rBVang.Text = "Vàng";
            rBVang.UseVisualStyleBackColor = true;
            // 
            // rBTrang
            // 
            rBTrang.AutoSize = true;
            rBTrang.Location = new Point(6, 96);
            rBTrang.Name = "rBTrang";
            rBTrang.Size = new Size(67, 24);
            rBTrang.TabIndex = 1;
            rBTrang.TabStop = true;
            rBTrang.Text = "Trắng";
            rBTrang.UseVisualStyleBackColor = true;
            // 
            // rBDo
            // 
            rBDo.AutoSize = true;
            rBDo.Location = new Point(6, 42);
            rBDo.Name = "rBDo";
            rBDo.Size = new Size(50, 24);
            rBDo.TabIndex = 0;
            rBDo.TabStop = true;
            rBDo.Text = "Đỏ";
            rBDo.UseVisualStyleBackColor = true;
            // 
            // btnSothich
            // 
            btnSothich.Location = new Point(95, 370);
            btnSothich.Name = "btnSothich";
            btnSothich.Size = new Size(239, 51);
            btnSothich.TabIndex = 2;
            btnSothich.Text = "Sở Thích Của Bạn";
            btnSothich.UseVisualStyleBackColor = true;
            btnSothich.Click += btnSothich_Click;
            // 
            // btnMaubanthich
            // 
            btnMaubanthich.Location = new Point(483, 370);
            btnMaubanthich.Name = "btnMaubanthich";
            btnMaubanthich.Size = new Size(239, 51);
            btnMaubanthich.TabIndex = 3;
            btnMaubanthich.Text = "Màu bạn thích";
            btnMaubanthich.UseVisualStyleBackColor = true;
            btnMaubanthich.Click += btnMaubanthich_Click;
            // 
            // button1
            // 
            button1.Location = new Point(372, 370);
            button1.Name = "button1";
            button1.Size = new Size(67, 51);
            button1.TabIndex = 4;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnMaubanthich);
            Controls.Add(btnSothich);
            Controls.Add(gBMauthich);
            Controls.Add(gBSothich);
            Name = "Bai2";
            Text = "Bai2";
            gBSothich.ResumeLayout(false);
            gBSothich.PerformLayout();
            gBMauthich.ResumeLayout(false);
            gBMauthich.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBSothich;
        private GroupBox gBMauthich;
        private CheckBox cBDidulich;
        private CheckBox cBXemphim;
        private CheckBox cBDimuasam;
        private CheckBox cBChoithethao;
        private CheckBox cBNghenhac;
        private RadioButton rBTim;
        private RadioButton rBHong;
        private RadioButton rBVang;
        private RadioButton rBTrang;
        private RadioButton rBDo;
        private Button btnSothich;
        private Button btnMaubanthich;
        private Button button1;
    }
}