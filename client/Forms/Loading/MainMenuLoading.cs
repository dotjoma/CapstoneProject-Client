using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.Loading
{
    public partial class MainMenuLoading : Form
    {
        int timerCount = 0;
        public MainMenuLoading()
        {
            InitializeComponent();
        }

        private void MainMenuLoading_Load(object sender, EventArgs e)
        {
            LoadingTimer.Start();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            if (lblLoading.InvokeRequired)
            {
                lblLoading.Invoke(new Action(() => UpdateLoadingText()));
            }
            else
            {
                UpdateLoadingText();
            }
        }

        private void UpdateLoadingText()
        {
            switch (timerCount)
            {
                case 1:
                    lblLoading.Text = "Loading."; break;

                case 2:
                    lblLoading.Text = "Loading.."; break;

                case 3:
                    lblLoading.Text = "Loading..."; break;

                default:
                    timerCount = 0; break;
            }

            timerCount++;
        }
    }
}
