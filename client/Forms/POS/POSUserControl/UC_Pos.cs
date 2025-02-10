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

namespace client.Forms.POS.POSUserControl
{
    public partial class UC_Pos : UserControl
    {
        public UC_Pos()
        {
            InitializeComponent();
            var products = new List<Product>
            {
                new Product(1,"Product 1", "Description 1", 100, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(2,"Product 2", "Description 2", 150, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(3,"Product 3", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(4,"Product 4", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(5,"Product 5", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(6,"Product 6", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(7,"Product 7", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(8,"Product 8", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(9,"Product 9", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(10,"Product 10", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(11,"Product 11", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(12,"Product 12", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(13,"Product 13", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(14,"Product 14", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(15,"Product 15", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(16,"Product 16", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(17,"Product 17", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(18,"Product 18", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(19,"Product 19", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(20,"Product 20", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(21,"Product 21", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(22,"Product 22", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(23,"Product 23", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(24,"Product 24", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png"),
                new Product(25,"Product 25", "Description 3", 200, "E:\\Visual Studio 2022\\Projects\\CapstoneProject\\client\\client\\Resources\\Images\\ramen.png")
            };

            // Create and add ProductDisplay control
            var productDisplay = new ProductDisplay(products)
            {
                Dock = DockStyle.Fill
            };
            pnlContainer.Controls.Add(productDisplay);
        }
    }
}
