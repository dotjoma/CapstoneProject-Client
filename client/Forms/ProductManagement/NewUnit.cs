using client.Controllers;
using client.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace client.Forms.ProductManagement
{
    public partial class NewUnit : Form
    {
        private readonly UnitController _unitController = new UnitController();

        private readonly AddProduct _parentForm;

        public NewUnit(AddProduct parent)
        {
            InitializeComponent();

            _parentForm = parent;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ToggleButton(false);
            await Task.Delay(50);

            string name = txtName.Text.Trim();
            string desc = rtbDescription.Text.Trim();

            try
            {
                HandleUnit(name, desc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            finally
            {
                ToggleButton(true);
            }
        }

        private async void HandleUnit(string unitName, string unitDesc)
        {
            bool response = await _unitController.Create(unitName, unitDesc);
            if (response)
            {
                MessageBox.Show($"Unit '{unitName}' has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

                bool getUnits = await _unitController.Get();
                if (getUnits)
                {
                    _parentForm.GetUnit();
                }
            }
            else
            {
                ToggleButton(true);
            }
        }

        private void ToggleButton(Boolean tog)
        {
            btnSave.Enabled = tog;
            string message = (tog) ? "Save" : "Saving...";
            btnSave.Text = message;
        }

        private void NewUnit_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
        }
    }
}
