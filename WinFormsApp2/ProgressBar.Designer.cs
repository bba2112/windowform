namespace WinFormsApp2
{
    partial class ProgressBar
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
            lbValue = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            btnStart = new Button();
            btnStop = new Button();
            btnExit = new Button();
            txtIncrement = new TextBox();
            txtInterval = new TextBox();
            SuspendLayout();
            // 
            // lbValue
            // 
            lbValue.AutoSize = true;
            lbValue.Location = new Point(367, 89);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(50, 20);
            lbValue.TabIndex = 0;
            lbValue.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 257);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Increment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 355);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Interval";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(88, 147);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(625, 29);
            progressBar1.TabIndex = 3;
            progressBar1.Click += progressBar1_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(88, 201);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(351, 201);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(619, 201);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtIncrement
            // 
            txtIncrement.Location = new Point(237, 257);
            txtIncrement.Multiline = true;
            txtIncrement.Name = "txtIncrement";
            txtIncrement.Size = new Size(125, 34);
            txtIncrement.TabIndex = 7;
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(237, 341);
            txtInterval.Multiline = true;
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(125, 34);
            txtInterval.TabIndex = 8;
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInterval);
            Controls.Add(txtIncrement);
            Controls.Add(btnExit);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbValue);
            Name = "ProgressBar";
            Text = "ProgressBar";
            Load += ProgressBar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbValue;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Button btnStart;
        private Button btnStop;
        private Button btnExit;
        private TextBox txtIncrement;
        private TextBox txtInterval;
    }
}