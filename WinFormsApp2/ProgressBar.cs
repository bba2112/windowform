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
    public partial class ProgressBar : Form
    {
        private bool dangchay = false;
        private int increment;
        private int interval;
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!dangchay)
            {
                if (int.TryParse(txtIncrement.Text, out increment) && int.TryParse(txtInterval.Text, out interval))
                {
                    // Ngung khong cho chinh sua
                    txtIncrement.ReadOnly = true;
                    txtInterval.ReadOnly = true;

                    dangchay = true;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;

                    while (dangchay)
                    {
                        // Tang gia tri progress bar
                        progressBar1.Value += increment;

                        // ProgressBar full thi reset
                        if (progressBar1.Value >= progressBar1.Maximum)
                            progressBar1.Value = progressBar1.Minimum;

                        // Cap nhat label
                        lbValue.Text = progressBar1.Value.ToString();

                        // Delay
                        await Task.Delay(interval);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy Nhập giá trị cho increment và interval");
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // mở chỉnh sửa
            txtIncrement.ReadOnly = false;
            txtInterval.ReadOnly = false;

            dangchay = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
