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
    public partial class NewUnit : Form
    {
        UnitController unitController = new UnitController();

        private string _title = string.Empty;
        private string _name = string.Empty;
        private string _label = string.Empty;

        private readonly AddInventoryItem _parentForm;
        public NewUnit(string title, string label, string name, AddInventoryItem parent)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this._title = title;
            this._label = label;
            this._name = name;

            this._parentForm = parent;
        }

        private void NewUnit_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _title;
            txtName.PlaceholderText = _name;
            txtSymbol.Enabled = (_label == "UnitType") ? false : true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string? name = txtName.Text.Trim();
            string? symbol = txtSymbol.Text.Trim();

            await SaveUnit(name, symbol);
        }

        private async Task SaveUnit(string name, string symbol)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Unit name is empty", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_label)
            {
                case "UnitType":
                    bool typeCreated = await unitController.CreateUnitType(name, symbol);
                    if(typeCreated)
                    {
                        this.Dispose();

                        var getUnitTypes = await unitController.GetAllInventoryUnitTypes();
                        if (getUnitTypes.Any())
                        {
                            _parentForm.GetInventoryUnitType();
                        }
                    }

                    break;
                case "UnitMeasure":
                    bool measureCreated = await unitController.CreateUnitMeasure(name, symbol);
                    if (measureCreated)
                    {
                        this.Dispose();

                        var getUnitMeasures = await unitController.GetAllInventoryUnitMeasures();
                        if (getUnitMeasures.Any())
                        {
                            _parentForm.GetInventoryUnitMeasure();
                        }
                    }

                    break;
                default:
                    Logger.Write("SAVE_UNIT_TYPE", "Unknown unit");
                    break;
            }
        }
    }
}
