using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
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
using LiveChartsCore.SkiaSharpView.VisualElements;

namespace client.Forms
{
    public partial class Dashboard: Form
    {
        private CartesianChart cartesianChart = new CartesianChart();
        private Panel seasonalAnalyticsPanel = new Panel();
        private Button btnWeekly = new Button();
        private Button btnMonthly = new Button();
        private Button btnYearly = new Button();

        public Dashboard()
        {
            InitializeComponent();
            LoadSeasonalityAnalysis();
            LoadInventoryTrends();
            LoadPredictiveAnalyticsPanel();
            LoadBestSellingMenus();
        }

        private void LoadSeasonalityAnalysis()
        {
            seasonalAnalyticsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke
            };

            // Title Label
            var titleLabel = new Label
            {
                Text = "Seasonality Analysis - Sales Trends",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40
            };

            // Button Panel
            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 40,
                FlowDirection = FlowDirection.LeftToRight,
                BackColor = Color.WhiteSmoke
            };

            // Create buttons
            btnWeekly = CreateFlatButton("Weekly");
            btnMonthly = CreateFlatButton("Monthly", isActive: true); // Default active
            btnYearly = CreateFlatButton("Yearly");

            // Add buttons to panel
            buttonPanel.Controls.Add(btnWeekly);
            buttonPanel.Controls.Add(btnMonthly);
            buttonPanel.Controls.Add(btnYearly);

            // Assign event handlers
            btnWeekly.Click += (sender, e) => HandleButtonClick(sender as Button);
            btnMonthly.Click += (sender, e) => HandleButtonClick(sender as Button);
            btnYearly.Click += (sender, e) => HandleButtonClick(sender as Button);

            // Chart
            cartesianChart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke
            };

            // Add controls to the panel
            seasonalAnalyticsPanel.Controls.Clear();
            seasonalAnalyticsPanel.Controls.Add(cartesianChart);
            seasonalAnalyticsPanel.Controls.Add(buttonPanel);
            seasonalAnalyticsPanel.Controls.Add(titleLabel);

            seasonalAnalytics.Controls.Clear();
            seasonalAnalytics.Controls.Add(seasonalAnalyticsPanel);

            // Load the default monthly data
            UpdateChartData("Monthly");
        }

        private Button CreateFlatButton(string text, bool isActive = false)
        {
            return new Button
            {
                Text = text,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = isActive ? Color.White : Color.Black,
                BackColor = isActive ? Color.DodgerBlue : Color.WhiteSmoke,
                FlatStyle = FlatStyle.Flat,
                Width = 100,
                Height = 30,
                Margin = new Padding(5, 5, 5, 5)
            };
        }

        private void HandleButtonClick(Button? clickedButton)
        {
            btnWeekly.BackColor = Color.WhiteSmoke;
            btnWeekly.ForeColor = Color.Black;

            btnMonthly.BackColor = Color.WhiteSmoke;
            btnMonthly.ForeColor = Color.Black;

            btnYearly.BackColor = Color.WhiteSmoke;
            btnYearly.ForeColor = Color.Black;

            clickedButton!.BackColor = Color.DodgerBlue;
            clickedButton.ForeColor = Color.White;

            UpdateChartData(clickedButton.Text);
        }

        private void UpdateChartData(string timeFrame)
        {
            string[] labels;
            double[] salesData;

            switch (timeFrame)
            {
                case "Weekly":
                    labels = new[] { "Week 1", "Week 2", "Week 3", "Week 4" };
                    salesData = new double[] { 4500, 5200, 4700, 5000 };
                    break;

                case "Monthly":
                    labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                    salesData = new double[] { 1200, 1500, 1800, 2500, 2200, 2800, 3000, 2700, 2600, 1900, 1700, 1400 };
                    break;

                case "Yearly":
                    labels = new[] { "2020", "2021", "2022", "2023", "2024" };
                    salesData = new double[] { 15000, 17000, 18000, 20000, 22000 };
                    break;

                default:
                    return;
            }

            var seasonalitySeries = new LineSeries<double>
            {
                Values = salesData,
                Name = timeFrame + " Sales",
                Stroke = new SolidColorPaint(SKColors.Green, 3),
                Fill = null,
                GeometrySize = 6
            };

            cartesianChart.Series = new ISeries[] { seasonalitySeries };

            // X-Axis Labels
            cartesianChart.XAxes = new[]
            {
                new LiveChartsCore.SkiaSharpView.Axis
                {
                    Labels = labels,
                    Name = timeFrame,
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 12
                }
            };

            // Y-Axis (Sales Amount)
            cartesianChart.YAxes = new[]
            {
                new LiveChartsCore.SkiaSharpView.Axis
                {
                    Name = "Sales ($)",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 12
                }
            };
        }

        private void LoadInventoryTrends()
        {
            CartesianChart cartesianChart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke
            };

            var products = new[] { "Burger", "Milk Tea", "Pizza", "Fries", "Spaghetti" };
            var salesCount = new double[] { 200, 150, 90, 300, 50 };

            var sortedData = products.Zip(salesCount, (p, s) => new { Product = p, Sales = s })
                                     .OrderByDescending(x => x.Sales)
                                     .ToList();

            var colors = new SKColor[] { SKColors.DarkGreen, SKColors.Blue, SKColors.Blue, SKColors.Blue, SKColors.Blue };

            var series = sortedData.Select((x, index) => new ColumnSeries<double>
            {
                Values = new double[] { x.Sales },
                Name = x.Product,
                Fill = new SolidColorPaint(colors[index]),
                Stroke = new SolidColorPaint(SKColors.Black) { StrokeThickness = 2 },
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsSize = 14,
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top
            }).ToArray();

            var trendData = CalculateMovingAverage(sortedData.Select(x => x.Sales).ToArray(), 3);
            var trendSeries = new LineSeries<double>
            {
                Values = trendData,
                Name = "Trend",
                Stroke = new SolidColorPaint(SKColors.Red) { StrokeThickness = 3 },
                GeometrySize = 10,
                GeometryFill = new SolidColorPaint(SKColors.Red)
            };

            cartesianChart.Series = series.Concat(new ISeries[] { trendSeries }).ToArray();

            cartesianChart.XAxes = new[]
            {
                new LiveChartsCore.SkiaSharpView.Axis
                {
                    Labels = sortedData.Select(x => x.Product).ToArray(),
                    Name = "Products",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 14
                }
            };

            // Y-Axis (Sales Count)
            cartesianChart.YAxes = new[]
            {
                new LiveChartsCore.SkiaSharpView.Axis
                {
                    Name = "Sales Count",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 14
                }
            };

            // Set the tooltip finding strategy (correct usage)
            cartesianChart.FindingStrategy = LiveChartsCore.Measure.FindingStrategy.CompareOnlyX;

            // 🏷️ Add Chart Title
            cartesianChart.Title = new LabelVisual
            {
                Text = "Inventory Sales Trends",
                TextSize = 18,
                Paint = new SolidColorPaint(SKColors.Black),
                Padding = new LiveChartsCore.Drawing.Padding(10)
            };

            // Add chart to the panel
            inventoryTrends.Controls.Clear();
            inventoryTrends.Controls.Add(cartesianChart);
        }


        private double[] CalculateMovingAverage(double[] data, int period)
        {
            if (data.Length < period) return data;

            double[] result = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                int start = Math.Max(0, i - period + 1);
                result[i] = data.Skip(start).Take(i - start + 1).Average();
            }
            return result;
        }

        private void LoadPredictiveAnalyticsPanel()
        {
            // Create the CartesianChart dynamically
            CartesianChart cartesianChart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke
            };

            // Dummy Data: Sales over the past 6 months
            var months = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            var salesData = new double[] { 1200, 1500, 1800, 2500, 2800, 3200 }; // Sales in $

            // Calculate Forecast (Simple Moving Average)
            var predictedSales = PredictSales(salesData);

            // Actual Sales Line
            var actualSalesSeries = new LineSeries<double>
            {
                Values = salesData,
                Name = "Actual Sales",
                Stroke = new SolidColorPaint(SKColors.Blue, 3),
                Fill = null,
                GeometrySize = 6
            };

            // Predicted Sales Line (Future Trend)
            var predictedSalesSeries = new LineSeries<double>
            {
                Values = predictedSales,
                Name = "Predicted Sales",
                Stroke = new SolidColorPaint(SKColors.Red, 3),
                Fill = null,
                GeometrySize = 6,
                LineSmoothness = 0.8f // Smooth curve
            };

            // Assign Data
            cartesianChart.Series = new ISeries[] { actualSalesSeries, predictedSalesSeries };

            // X-Axis Labels (Months)
            cartesianChart.XAxes = new[]
            {
                new LiveChartsCore.SkiaSharpView.Axis
                {
                    Labels = months,
                    Name = "Months",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 12
                }
            };

            // Y-Axis (Sales in $)
            cartesianChart.YAxes = new[]
            {
                new LiveChartsCore.SkiaSharpView.Axis
                {
                    Name = "Sales ($)",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 12
                }
            };

            // Clear panel and add chart
            predictiveAnalytics.Controls.Clear();
            predictiveAnalytics.Controls.Add(cartesianChart);
        }

        private double[] PredictSales(double[] sales)
        {
            int n = sales.Length;
            double[] forecast = new double[n + 2]; // Predict next 2 months

            // Copy existing sales data
            for (int i = 0; i < n; i++)
                forecast[i] = sales[i];

            // Moving Average Formula
            for (int i = n; i < forecast.Length; i++)
                forecast[i] = (forecast[i - 1] + forecast[i - 2] + forecast[i - 3]) / 3;

            return forecast;
        }

        private void LoadBestSellingMenus()
        {
            // Create a Cartesian Chart (Bar Chart)
            CartesianChart cartesianChart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke // Light background for modern look
            };

            // Best-selling menu data
            var menuData = new List<(string Name, int Sold)>
            {
                ("Chicken Wings", 98),
                ("Extra Rice", 85),
                ("Burger", 76),
                ("Fried Chicken", 67),
                ("Pasta", 59),
                ("Pizza", 55),
                ("Coffee", 47),
                ("Smoothie", 40),
                ("Ice Cream", 32),
                ("Tacos", 25)
            };

            // Extract names & values
            var labels = menuData.Select(m => m.Name).ToArray();
            var values = menuData.Select(m => (double)m.Sold).ToArray();

            // Create Bar Series
            var barSeries = new ColumnSeries<double>
            {
                Values = values,
                Name = "Best Selling Menus",
                Stroke = new SolidColorPaint(SKColors.Black, 2), // Border for bars
                Fill = new SolidColorPaint(SKColors.DeepSkyBlue), // Bar color
                DataLabelsPaint = new SolidColorPaint(SKColors.Black), // Label color
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top
            };

            // Assign Series to Chart
            cartesianChart.Series = new ISeries[] { barSeries };

            // Configure X-Axis Labels
            cartesianChart.XAxes = new[]
            {
                new LiveChartsCore.SkiaSharpView.Axis
                {
                    Labels = labels,
                    LabelsRotation = 0, // Rotate labels if needed
                    TextSize = 12,
                    Name = "Menu Items",
                    NamePaint = new SolidColorPaint(SKColors.Black)
                }
            };

            // Configure Y-Axis (Quantity Sold)
            cartesianChart.YAxes = new[]
            {
                new LiveChartsCore.SkiaSharpView.Axis
                {
                    Name = "Quantity Sold",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    TextSize = 12
                }
            };

            // Add chart to form (inside a panel for layout control)
            topSellingMenus.Controls.Clear();
            topSellingMenus.Controls.Add(cartesianChart);
        }
    }
}
