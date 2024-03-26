namespace WinFormsApp2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProgressBar = new Button();
            btnexit = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btntimer = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // btnProgressBar
            // 
            btnProgressBar.Location = new Point(82, 63);
            btnProgressBar.Name = "btnProgressBar";
            btnProgressBar.Size = new Size(130, 29);
            btnProgressBar.TabIndex = 0;
            btnProgressBar.Text = "ProgressBar";
            btnProgressBar.UseVisualStyleBackColor = true;
            btnProgressBar.Click += btnProgressBar_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(382, 520);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(130, 29);
            btnexit.TabIndex = 1;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(382, 63);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 2;
            button1.Text = "MessageBox";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(692, 63);
            button2.Name = "button2";
            button2.Size = new Size(195, 29);
            button2.TabIndex = 3;
            button2.Text = "Thông Tin Sinh Viên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(82, 222);
            button3.Name = "button3";
            button3.Size = new Size(130, 29);
            button3.TabIndex = 4;
            button3.Text = "TreeView";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btntimer
            // 
            btntimer.Location = new Point(382, 222);
            btntimer.Name = "btntimer";
            btntimer.Size = new Size(130, 29);
            btntimer.TabIndex = 5;
            btntimer.Text = "Timer";
            btntimer.UseVisualStyleBackColor = true;
            btntimer.Click += btntimer_Click;
            // 
            // button4
            // 
            button4.Location = new Point(692, 222);
            button4.Name = "button4";
            button4.Size = new Size(162, 29);
            button4.TabIndex = 6;
            button4.Text = "Soạn Thảo Văn Bản";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(368, 370);
            button5.Name = "button5";
            button5.Size = new Size(162, 29);
            button5.TabIndex = 7;
            button5.Text = "Câu 2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1049, 589);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btntimer);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnexit);
            Controls.Add(btnProgressBar);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProgressBar;
        private Button btnexit;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btntimer;
        private Button button4;
        private Button button5;
    }
}