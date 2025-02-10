using client.Forms.POS.POSUserControl;
using client.Forms.UserControll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.POS
{
    public partial class POS_MainMenu : Form
    {
        public POS_MainMenu()
        {
            InitializeComponent();
        }

        private void POS_MainMenu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ActiveButton(int btn)
        {
            var buttons = new[]
            {
                (1, btnPos),
                (2, btnOrders),
                (3, btnProducts)
            };

            buttons.ToList().ForEach(b => b.Item2.Checked = b.Item1 == btn);
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            ActiveButton(1);
            AddUserControl(new UC_Pos());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActiveButton(2);
            AddUserControl(new UC_Orders());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActiveButton(3);
            AddUserControl(new UC_Products());
        }
    }
}
