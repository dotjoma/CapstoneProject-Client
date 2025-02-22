using client.Controllers;
using client.Controls.Manage;
using client.Helpers;
using client.Models;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace client.Forms.POS.POSUserControl.ProductFoodCategory
{
    public partial class UC_Beverages : UserControl
    {
        private readonly ProductController _productController;
        public UC_Beverages()
        {
            InitializeComponent();
            _productController = new ProductController();
        }

        public async void DisplayProduct()
        {
            try
            {
                bool response = await _productController.Get();

                if (response)
                {
                    LoggerHelper.Write("RESPONSE", $"Received response: {response}");
                }
                else
                {
                    LoggerHelper.Write("RESPONSE", $"No any response from the server.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
