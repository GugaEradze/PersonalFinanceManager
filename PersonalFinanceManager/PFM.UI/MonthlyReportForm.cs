using PFM.Core.Enums;
using PFM.Core.Interfaces;
using PFM.Core.Entities;
using System.Windows.Forms.DataVisualization.Charting;

namespace PFM.UI
{
    public partial class MonthlyReportForm : Form
    {
        private readonly IRepository<Transaction> _transactionRepository;

        public MonthlyReportForm(IRepository<Transaction> transactionRepository)
        {
            InitializeComponent();
            _transactionRepository = transactionRepository;

            InitializeForm();
        }

        private void InitializeForm()
        {
            dtpMonth.Value = DateTime.Now;
            SetupChart();
            LoadReport();
        }

        private void SetupChart()
        {
            chartReport.Series.Clear();
            chartReport.ChartAreas.Clear();
            chartReport.Legends.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Title = "Day";
            chartArea.AxisY.Title = "Amount (₾)";
            chartArea.AxisX.Interval = 1;
            chartReport.ChartAreas.Add(chartArea);

            Legend legend = new Legend("MainLegend");
            legend.Docking = Docking.Top;
            chartReport.Legends.Add(legend);

            Series incomeSeries = new Series("Income");
            incomeSeries.ChartType = SeriesChartType.Column;
            incomeSeries.Color = Color.Green;
            incomeSeries["PointWidth"] = "0.2";
            chartReport.Series.Add(incomeSeries);

            Series expenseSeries = new Series("Expenses");
            expenseSeries.ChartType = SeriesChartType.Column;
            expenseSeries.Color = Color.Red;
            expenseSeries["PointWidth"] = "0.2";
            chartReport.Series.Add(expenseSeries);
        }

        private async void LoadReport()
        {
            try
            {
                var selectedDate = dtpMonth.Value;
                var startDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);

                var allTransactions = await _transactionRepository.GetAllWithIncludesAsync();
                var monthTransactions = allTransactions
                    .Where(t => t.Date >= startDate && t.Date <= endDate)
                    .ToList();

                chartReport.Series["Income"].Points.Clear();
                chartReport.Series["Expenses"].Points.Clear();

                var dailyIncome = monthTransactions
                    .Where(t => t.Type == TransactionType.Income)
                    .GroupBy(t => t.Date.Day)
                    .Select(g => new { Day = g.Key, Total = g.Sum(t => t.Amount) })
                    .OrderBy(x => x.Day)
                    .ToList();

                var dailyExpenses = monthTransactions
                    .Where(t => t.Type == TransactionType.Expense)
                    .GroupBy(t => t.Date.Day)
                    .Select(g => new { Day = g.Key, Total = g.Sum(t => t.Amount) })
                    .OrderBy(x => x.Day)
                    .ToList();

                foreach (var item in dailyIncome)
                {
                    chartReport.Series["Income"].Points.AddXY(item.Day, item.Total);
                }

                foreach (var item in dailyExpenses)
                {
                    chartReport.Series["Expenses"].Points.AddXY(item.Day, item.Total);
                }

                var totalIncome = monthTransactions
                    .Where(t => t.Type == TransactionType.Income)
                    .Sum(t => t.Amount);

                var totalExpenses = monthTransactions
                    .Where(t => t.Type == TransactionType.Expense)
                    .Sum(t => t.Amount);

                var balance = totalIncome - totalExpenses;

                lblTotalIncome.Text = $"Total Income: {totalIncome:N2} ₾";
                lblTotalExpenses.Text = $"Total Expenses: {totalExpenses:N2} ₾";
                lblBalance.Text = $"Balance: {balance:N2} ₾";
                lblBalance.ForeColor = balance >= 0 ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
