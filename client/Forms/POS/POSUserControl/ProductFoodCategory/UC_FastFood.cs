using client.Controls.Manage;
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

namespace client.Forms.POS.POSUserControl.ProductFoodCategory
{
    public partial class UC_FastFood : UserControl
    {
        public UC_FastFood()
        {
            InitializeComponent();

            var products = new List<Product>
            {
                new Product(1,"Product 1", "Description 1", 100, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(2,"Product 2", "Description 2", 150, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png")
            };

            // Create and add ProductDisplay control
            var manageProduct = new Manage(products)
            {
                Dock = DockStyle.Fill
            };
            pnlContainer.Controls.Add(manageProduct);
        }
    }
}
