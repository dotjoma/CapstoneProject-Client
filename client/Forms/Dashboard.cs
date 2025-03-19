using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace client.Forms
{
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadSalesChart();
            LoadBestSellingChart();
            LoadProductPopularityChart();
        }

        private void LoadSalesChart()
        {
            // Clear previous data
            chartSalesPrediction.Series.Clear();
            chartSalesPrediction.ChartAreas.Clear();
            chartSalesPrediction.Titles.Clear();

            // Create chart area
            ChartArea chartArea = new ChartArea("SalesChart");
            chartArea.BackColor = Color.Transparent;
            chartArea.AxisX.Title = "Month";
            chartArea.AxisY.Title = "Sales (₱)";
            chartArea.AxisY.LabelStyle.Format = "₱#,##0";
            chartArea.AxisX.Interval = 1;

            // Customize gridlines
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Add chart area
            chartSalesPrediction.ChartAreas.Add(chartArea);

            // Create data series
            Series salesSeries = new Series("Monthly Sales");
            salesSeries.ChartType = SeriesChartType.Spline; // Smooth line for modern look
            salesSeries.BorderWidth = 3;
            salesSeries.Color = Color.FromArgb(52, 152, 219); // Modern blue
            salesSeries.MarkerStyle = MarkerStyle.Circle;
            salesSeries.MarkerSize = 6;
            salesSeries.MarkerColor = Color.Red;

            // Add gradient effect (optional)
            salesSeries.BackGradientStyle = GradientStyle.VerticalCenter;
            salesSeries.Color = Color.FromArgb(41, 128, 185);
            salesSeries.BackSecondaryColor = Color.FromArgb(142, 68, 173);

            // Add past sales data (Last 12 months)
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            Random rand = new Random();
            int baseSales = 50000; // Start base sales at ₱50,000

            for (int i = 0; i < 12; i++)
            {
                int sales = baseSales + rand.Next(-5000, 10000); // Random fluctuation
                salesSeries.Points.AddXY(months[i], sales);
            }

            // Predict future sales (Next 12 months)
            for (int i = 0; i < 12; i++)
            {
                int futureSales = baseSales + rand.Next(2000, 12000); // Growth pattern
                salesSeries.Points.AddXY(months[i] + " (Pred)", futureSales);
            }

            // Add series to chart
            chartSalesPrediction.Series.Add(salesSeries);

            // Set chart title
            Title title = new Title("Monthly Sales Trend (Past & Predicted)", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
            chartSalesPrediction.Titles.Add(title);

            // Enable animation effect
            chartSalesPrediction.Series[0]["LineTension"] = "0.5"; // Smooth curve
        }

        private void LoadBestSellingChart()
        {
            // Clear previous data
            chartBestSelling.Series.Clear();
            chartBestSelling.ChartAreas.Clear();
            chartBestSelling.Titles.Clear();

            // Create chart area with modern styling
            ChartArea chartArea = new ChartArea("BestSellingChart");
            chartArea.BackColor = Color.Transparent; // Transparent background
            chartArea.AxisX.Title = "Menu Item";
            chartArea.AxisY.Title = "Total Sold";
            chartArea.AxisY.LabelStyle.Format = "#,##0";

            // Customize gridlines for a modern look
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Add chart area
            chartBestSelling.ChartAreas.Add(chartArea);

            // Create data series with better colors
            Series productSeries = new Series("Best-Selling Products");
            productSeries.ChartType = SeriesChartType.Column; // Bar Chart
            productSeries.Color = Color.FromArgb(52, 152, 219); // Modern blue
            productSeries.BorderWidth = 2;
            productSeries.IsValueShownAsLabel = true; // Show values on top of bars
            productSeries.Font = new Font("Arial", 10, FontStyle.Bold);

            // Add best-selling product data (Sorted Mock Data)
            var products = new (string Name, int Sold)[]
            {
                ("Burger", 250),
                ("Fries", 320),
                ("Milk Tea", 410),
                ("Pizza", 380),
                ("Coffee", 290)
            }
            .OrderByDescending(p => p.Sold) // Sort from highest to lowest
            .ToArray();

            // Add products to chart dynamically
            foreach (var product in products)
            {
                productSeries.Points.AddXY(product.Name, product.Sold);
            }

            // Add series to chart
            chartBestSelling.Series.Add(productSeries);

            // Set chart title with modern font
            Title title = new Title("Best-Selling Menu Items", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
            chartBestSelling.Titles.Add(title);

            // Apply 3D effect for a modern look
            chartBestSelling.ChartAreas[0].Area3DStyle.Enable3D = true;

            // Animation Effect
            productSeries["DrawingStyle"] = "Cylinder"; // Cylinder effect for bars
            productSeries["PointWidth"] = "0.6"; // Adjust width of bars
        }

        private void LoadProductPopularityChart()
        {
            // Clear previous data
            chartProductPopularity.Series.Clear();
            chartProductPopularity.ChartAreas.Clear();
            chartProductPopularity.Titles.Clear();
            chartProductPopularity.Legends.Clear();

            // Create chart area
            ChartArea chartArea = new ChartArea("PopularityChart");
            chartArea.BackColor = Color.Transparent; // Transparent background
            chartProductPopularity.ChartAreas.Add(chartArea);

            // Create and configure legend
            Legend legend = new Legend
            {
                Docking = Docking.Right,
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.Transparent
            };
            chartProductPopularity.Legends.Add(legend);

            // Create data series
            Series productSeries = new Series("Product Popularity")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true, // Show percentage values
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            // Add product sales data (Mock Data)
            var products = new (string Name, int Sold)[]
            {
                ("Burger", 250),
                ("Fries", 320),
                ("Milk Tea", 410),
                ("Pizza", 380),
                ("Coffee", 290)
            };

            foreach (var product in products)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(product.Name, product.Sold);
                point.Label = $"#PERCENT{Environment.NewLine}({product.Sold})"; // Show percentage and actual sales
                point.LegendText = $"{product.Name}"; // Show product name in legend
                productSeries.Points.Add(point);
            }

            // Customize pie chart style
            productSeries["PieLabelStyle"] = "Outside"; // Labels outside
            productSeries["PieStartAngle"] = "120"; // Rotate for better visibility
            productSeries["Exploded"] = "true"; // Explode slices slightly
            productSeries["DoughnutRadius"] = "30"; // Adjust size if needed

            // Apply modern color palette
            chartProductPopularity.Palette = ChartColorPalette.BrightPastel;

            // Add series to chart
            chartProductPopularity.Series.Add(productSeries);

            // Set chart title
            Title title = new Title("Menu Item Popularity Share", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
            chartProductPopularity.Titles.Add(title);

            // Enable 3D effect for a modern look
            chartProductPopularity.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

    }
}
