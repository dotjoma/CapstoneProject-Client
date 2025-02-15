using client.Controls;
using client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Forms.POS.POSUserControl.FoodCategory;

namespace client.Forms.POS.POSUserControl
{
    public partial class UC_Pos : UserControl
    {
        public UC_Pos()
        {
            InitializeComponent();
        }

        private void UC_Pos_Load(object sender, EventArgs e)
        {
            AddUserControl(new UC_Beverages());
            ActiveButton(1);
            timer1.Start();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_Beverages());
            ActiveButton(1);
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_MainCourse());
            ActiveButton(2);
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_FastFood());
            ActiveButton(3);
        }

        private void ActiveButton(int btn)
        {
            var buttons = new[]
            {
                (1, btnBeverages),
                (2, btnMainCourse),
                (3, btnFastFood)
            };

            buttons.ToList().ForEach(b => b.Item2.Checked = b.Item1 == btn);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = $"{DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("hh:mm:ss tt").ToUpper()}";
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }
    }
}
