using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.BackupControl
{
    public partial class SelectedDataForm : Form
    {
        private BackupPanel _backupPanel;
        public SelectedDataForm(BackupPanel backupPanel)
        {
            InitializeComponent();
            _backupPanel = backupPanel;
        }

        private void SelectedDataForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            List<string> selectedTables = new List<string>();

            if (cbTransaction.Checked)
            {
                selectedTables.AddRange(new string[] { "transactions", "orderdetails", "payments" });
            }
            else
            {
                selectedTables.Remove("transactions");
                selectedTables.Remove("orderdetails");
                selectedTables.Remove("payments");
            }

            if (cbProducts.Checked)
            {
                selectedTables.AddRange(new string[] { "product", "category", "subcategory", "unit" });
            }
            else
            {
                selectedTables.Remove("product");
                selectedTables.Remove("category");
                selectedTables.Remove("subcategory");
                selectedTables.Remove("unit");
            }

            if (cbUsers.Checked)
            {
                selectedTables.AddRange(new string[] { "users", "account_locks", "login_attempts" });
            }
            else
            {
                selectedTables.Remove("users");
                selectedTables.Remove("account_locks");
                selectedTables.Remove("login_attempts");
            }

            if (selectedTables.Count == 0)
            {
                MessageBox.Show("Please select at least one table to back up.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _backupPanel.SelectedTables = selectedTables;
            this.Dispose();
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbSelectAll.Checked;

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox != cbSelectAll)
                {
                    checkBox.Checked = isChecked;
                }
            }
        }
    }
}
