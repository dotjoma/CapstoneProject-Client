using client.Controllers;
using client.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.InventoryManagement
{
    public partial class NewSupplier : Form
    {
        SupplierController _supplierController = new SupplierController();

        private readonly Form _parentForm;

        public NewSupplier(Form parent)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this._parentForm = parent;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text.Trim(); // required
            string contactPerson = txtContactPerson.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string address = rtbAddress.Text.Trim();
            bool isActive = cbIsActive.Checked;

            try
            {
                bool result = await _supplierController.CreateSupplier(supplierName, contactPerson, phone, email, address, isActive);
                if (result)
                {
                    //MessageBox.Show("Supplier created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    var getSuppliers = await _supplierController.GetAllInventorySuppliers();
                    if (getSuppliers.Any())
                    {
                        if (_parentForm is AddInventoryItem addForm)
                        {
                            addForm.GetInventorySupplier();
                        }
                        else if (_parentForm is AddBatch abForm)
                        {
                            abForm.GetInventorySupplier();
                        }
                        else if(_parentForm is EditBatch ebForm)
                        {
                            ebForm.GetInventorySupplier();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Logger.Write("CREATE SUPPLIER", $"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
