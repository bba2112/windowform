namespace WinFormsApp2
{
    partial class stvb
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
            components = new System.ComponentModel.Container();
            mSFile = new MenuStrip();
            tsmifile = new ToolStripMenuItem();
            tsmicook = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tsmiNgay = new ToolStripMenuItem();
            tsmiGio = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            tsmiFont = new ToolStripMenuItem();
            tsmiColor = new ToolStripMenuItem();
            tsmiAlign = new ToolStripMenuItem();
            tsmiAlignleft = new ToolStripMenuItem();
            tsmiRight = new ToolStripMenuItem();
            tsmiCenter = new ToolStripMenuItem();
            txtChuoi = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            mSFile.SuspendLayout();
            SuspendLayout();
            // 
            // mSFile
            // 
            mSFile.ImageScalingSize = new Size(20, 20);
            mSFile.Items.AddRange(new ToolStripItem[] { tsmifile, toolStripMenuItem1, toolStripMenuItem2 });
            mSFile.Location = new Point(0, 0);
            mSFile.Name = "mSFile";
            mSFile.Size = new Size(800, 28);
            mSFile.TabIndex = 0;
            mSFile.Text = "File";
            // 
            // tsmifile
            // 
            tsmifile.DropDownItems.AddRange(new ToolStripItem[] { tsmicook });
            tsmifile.Name = "tsmifile";
            tsmifile.Size = new Size(46, 24);
            tsmifile.Text = "File";
            // 
            // tsmicook
            // 
            tsmicook.Name = "tsmicook";
            tsmicook.ShortcutKeys = Keys.Alt | Keys.X;
            tsmicook.Size = new Size(163, 26);
            tsmicook.Text = "Exit";
            tsmicook.ToolTipText = "Alt + X";
            tsmicook.Click += tsmicook_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tsmiNgay, tsmiGio });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(59, 24);
            toolStripMenuItem1.Text = "Clock";
            // 
            // tsmiNgay
            // 
            tsmiNgay.Name = "tsmiNgay";
            tsmiNgay.Size = new Size(131, 26);
            tsmiNgay.Text = "Ngày ";
            tsmiNgay.Click += tsmiNgay_Click_1;
            // 
            // tsmiGio
            // 
            tsmiGio.Name = "tsmiGio";
            tsmiGio.Size = new Size(131, 26);
            tsmiGio.Text = "Giờ";
            tsmiGio.Click += tsmiGio_Click_1;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { tsmiFont, tsmiColor, tsmiAlign });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(70, 24);
            toolStripMenuItem2.Text = "Format";
            // 
            // tsmiFont
            // 
            tsmiFont.Name = "tsmiFont";
            tsmiFont.Size = new Size(224, 26);
            tsmiFont.Text = "Font";
            tsmiFont.Click += tsmiFont_Click_1;
            // 
            // tsmiColor
            // 
            tsmiColor.Name = "tsmiColor";
            tsmiColor.Size = new Size(224, 26);
            tsmiColor.Text = "Color";
            tsmiColor.Click += tsmiColor_Click_1;
            // 
            // tsmiAlign
            // 
            tsmiAlign.DropDownItems.AddRange(new ToolStripItem[] { tsmiAlignleft, tsmiRight, tsmiCenter });
            tsmiAlign.Name = "tsmiAlign";
            tsmiAlign.Size = new Size(224, 26);
            tsmiAlign.Text = "Align";
            // 
            // tsmiAlignleft
            // 
            tsmiAlignleft.Name = "tsmiAlignleft";
            tsmiAlignleft.Size = new Size(224, 26);
            tsmiAlignleft.Text = "Left";
            tsmiAlignleft.Click += tsmiAlignleft_Click_1;
            // 
            // tsmiRight
            // 
            tsmiRight.Name = "tsmiRight";
            tsmiRight.Size = new Size(224, 26);
            tsmiRight.Text = "Right";
            tsmiRight.Click += tsmiRight_Click_1;
            // 
            // tsmiCenter
            // 
            tsmiCenter.Name = "tsmiCenter";
            tsmiCenter.Size = new Size(224, 26);
            tsmiCenter.Text = "Center";
            tsmiCenter.Click += tsmiCenter_Click_1;
            // 
            // txtChuoi
            // 
            txtChuoi.Location = new Point(12, 82);
            txtChuoi.Multiline = true;
            txtChuoi.Name = "txtChuoi";
            txtChuoi.Size = new Size(544, 290);
            txtChuoi.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // stvb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtChuoi);
            Controls.Add(mSFile);
            MainMenuStrip = mSFile;
            Name = "stvb";
            Text = "stvb";
            mSFile.ResumeLayout(false);
            mSFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mSFile;
        private TextBox txtChuoi;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem tsmifile;
        private ToolStripMenuItem tsmicook;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tsmiNgay;
        private ToolStripMenuItem tsmiGio;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem tsmiFont;
        private ToolStripMenuItem tsmiColor;
        private ToolStripMenuItem tsmiAlign;
        private ToolStripMenuItem tsmiAlignleft;
        private ToolStripMenuItem tsmiRight;
        private ToolStripMenuItem tsmiCenter;
    }
}