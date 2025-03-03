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

namespace client.Forms.DiscountManagement
{
    public partial class DiscountHome : Form
    {
        public DiscountHome()
        {
            InitializeComponent();
        }

        private void DiscountHome_Load(object sender, EventArgs e)
        {
            dgvDiscount.Rows.Add(dgvDiscount.Rows.Count + 1, "Senior Citizen", "percentage", "20", "Yes", "all", "Active");
            dgvDiscount.Rows.Add(dgvDiscount.Rows.Count + 2, "PWD           ", "percentage", "20", "Yes", "all", "Active");
            dgvDiscount.Rows.Add(dgvDiscount.Rows.Count + 2, "PWD           ", "percentage", "20", "Yes", "all", "Active");
            dgvDiscount.Rows.Add(dgvDiscount.Rows.Count + 2, "PWD           ", "percentage", "20", "Yes", "all", "Active");
            dgvDiscount.Rows.Add(dgvDiscount.Rows.Count + 2, "PWD           ", "percentage", "20", "Yes", "all", "Active");
            dgvDiscount.Rows.Add(dgvDiscount.Rows.Count + 2, "PWD           ", "percentage", "20", "Yes", "all", "Active");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddDiscount addDiscount = new AddDiscount();
            addDiscount.StartPosition = FormStartPosition.Manual;
            addDiscount.StartPosition = FormStartPosition.CenterParent;
            addDiscount.ShowDialog(this);
        }
    }
}
