using client.Controllers;
using client.Controls.Products;
using client.Models;
using client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.POS.POSUserControl.FoodCategory
{
    public partial class UC_MainCourse : UserControl
    {
        private readonly ProductController _productController;
        public UC_MainCourse()
        {
            InitializeComponent();
            _productController = new ProductController();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            var productController = new ProductController();
            if (await productController.Get())
            {
                pnlContainer.Controls.Clear();

                var productDisplay = new Display(CurrentProduct.AllProduct)
                {
                    Dock = DockStyle.Fill
                };
                pnlContainer.Controls.Add(productDisplay);
            }
        }
    }
}
