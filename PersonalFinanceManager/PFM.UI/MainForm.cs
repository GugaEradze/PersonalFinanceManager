using PFM.Core.Entities;
using PFM.Core.Interfaces;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace PFM.UI
{
    public partial class MainForm : Form
    {
        private readonly IRepository<Transaction> _transactionRepository;
        private readonly IRepository<Category> _categoryRepository;

        public MainForm(
            IRepository<Transaction> transactionRepository,
            IRepository<Category> categoryRepository)
        {
            InitializeComponent();
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;

            InitializeForm();
        }

        private void InitializeForm()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("All");
            cmbType.Items.Add("Income");
            cmbType.Items.Add("Expense");
            cmbType.SelectedIndex = 0;

            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;

            SetupDataGridView();

            LoadTransactions();

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void SetupDataGridView()
        {
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.Columns.Clear();

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Visible = false
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Date",
                HeaderText = "Date",
                DataPropertyName = "Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" },
                Width = 120
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Description",
                DataPropertyName = "Description",
                Width = 250
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Category",
                DataPropertyName = "Category.Name",
                Width = 150
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Type",
                DataPropertyName = "Type",
                Width = 100
            });

            dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                HeaderText = "Amount",
                DataPropertyName = "Amount",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                Width = 120
            });
        }

        private async void LoadTransactions()
        {
            try
            {
                var transactions = await _transactionRepository.GetAllWithIncludesAsync();

                dgvTransactions.DataSource = transactions.OrderByDescending(t => t.Date).ToList();

                UpdateSummary(transactions);

                dgvTransactions.ClearSelection();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummary(IEnumerable<Transaction> transactions)
        {
            var totalIncome = transactions
                .Where(t => t.Type == Core.Enums.TransactionType.Income)
                .Sum(t => t.Amount);

            var totalExpenses = transactions
                .Where(t => t.Type == Core.Enums.TransactionType.Expense)
                .Sum(t => t.Amount);

            var balance = totalIncome - totalExpenses;

            lblTotalIncome.Text = $"Total Income : {totalIncome:N2} ₾";
            lblTotalExpenses.Text = $"Total Expenses : {totalExpenses:N2} ₾";
            lblBalance.Text = $"Balance : {balance:N2} ₾";

            lblBalance.ForeColor = balance >= 0 ? Color.Green : Color.Red;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await ApplyFilters();
        }

        private async Task ApplyFilters()
        {
            try
            {
                var transactions = await _transactionRepository.GetAllWithIncludesAsync();

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    transactions = transactions.Where(t =>
                        t.Description.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                        (t.Category != null && t.Category.Name.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                    );
                }

                if (cmbType.SelectedItem != null && cmbType.SelectedItem.ToString() != "All")
                {
                    var selectedType = cmbType.SelectedItem.ToString();
                    if (selectedType == "Income")
                    {
                        transactions = transactions.Where(t => t.Type == Core.Enums.TransactionType.Income);
                    }
                    else if (selectedType == "Expense")
                    {
                        transactions = transactions.Where(t => t.Type == Core.Enums.TransactionType.Expense);
                    }
                }

                transactions = transactions.Where(t =>
                    t.Date.Date >= dtpFromDate.Value.Date &&
                    t.Date.Date <= dtpToDate.Value.Date
                );

                dgvTransactions.DataSource = transactions.OrderByDescending(t => t.Date).ToList();
                UpdateSummary(transactions);

                dgvTransactions.ClearSelection();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filters: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditTransactionForm(
                _transactionRepository,
                _categoryRepository);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTransactions();
            }
        }

        private async void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ApplyFilters();
        }

        private async void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            await ApplyFilters();
        }

        private async void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            await ApplyFilters();
        }

        private void dgvTransactions_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dgvTransactions.SelectedRows.Count > 0;
            btnDelete.Enabled = dgvTransactions.SelectedRows.Count > 0;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to delete.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this transaction?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var selectedRow = dgvTransactions.SelectedRows[0];
                    var transactionId = (int)selectedRow.Cells["Id"].Value;

                    var transaction = await _transactionRepository.GetByIdAsync(transactionId);
                    if (transaction != null)
                    {
                        await _transactionRepository.DeleteAsync(transaction);
                        MessageBox.Show("Transaction deleted successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadTransactions();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting transaction: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to edit.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var selectedRow = dgvTransactions.SelectedRows[0];
                var transactionId = (int)selectedRow.Cells["Id"].Value;

                var transaction = await _transactionRepository.GetByIdAsync(transactionId);

                if (transaction != null)
                {
                    transaction.Category = await _categoryRepository.GetByIdAsync(transaction.CategoryId);

                    var editForm = new AddEditTransactionForm(
                        _transactionRepository,
                        _categoryRepository,
                        transaction);

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTransactions();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error editing transaction: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddTransaction.PerformClick();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private async void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoriesForm = new CategoriesForm(_categoryRepository);
            categoriesForm.ShowDialog();

            LoadTransactions();
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var transactions = await _transactionRepository.GetAllWithIncludesAsync();
                var transactionsList = transactions.OrderByDescending(t => t.Date).ToList();

                if (!transactionsList.Any())
                {
                    MessageBox.Show("No transactions to export.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Export Transactions to Excel";
                    saveFileDialog.FileName = $"Transactions_{DateTime.Now:yyyy-MM-dd}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (var package = new ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Transactions");

                            worksheet.Cells[1, 1].Value = "Date";
                            worksheet.Cells[1, 2].Value = "Description";
                            worksheet.Cells[1, 3].Value = "Category";
                            worksheet.Cells[1, 4].Value = "Type";
                            worksheet.Cells[1, 5].Value = "Amount";
                            worksheet.Cells[1, 6].Value = "Currency";

                            using (var range = worksheet.Cells[1, 1, 1, 6])
                            {
                                range.Style.Font.Bold = true;
                                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }

                            int row = 2;
                            foreach (var transaction in transactionsList)
                            {
                                worksheet.Cells[row, 1].Value = transaction.Date.ToString("dd/MM/yyyy");
                                worksheet.Cells[row, 2].Value = transaction.Description;
                                worksheet.Cells[row, 3].Value = transaction.Category?.Name ?? "N/A";
                                worksheet.Cells[row, 4].Value = transaction.Type.ToString();
                                worksheet.Cells[row, 5].Value = transaction.Amount;
                                worksheet.Cells[row, 6].Value = transaction.Currency;

                                if (transaction.Type == Core.Enums.TransactionType.Income)
                                {
                                    worksheet.Cells[row, 5].Style.Font.Color.SetColor(System.Drawing.Color.Green);
                                }
                                else
                                {
                                    worksheet.Cells[row, 5].Style.Font.Color.SetColor(System.Drawing.Color.Red);
                                }

                                row++;
                            }

                            row += 2;
                            var totalIncome = transactionsList
                                .Where(t => t.Type == Core.Enums.TransactionType.Income)
                                .Sum(t => t.Amount);

                            var totalExpenses = transactionsList
                                .Where(t => t.Type == Core.Enums.TransactionType.Expense)
                                .Sum(t => t.Amount);

                            var balance = totalIncome - totalExpenses;

                            worksheet.Cells[row, 1].Value = "Total Income:";
                            worksheet.Cells[row, 2].Value = totalIncome;
                            worksheet.Cells[row, 2].Style.Font.Color.SetColor(System.Drawing.Color.Green);
                            worksheet.Cells[row, 2].Style.Font.Bold = true;

                            row++;
                            worksheet.Cells[row, 1].Value = "Total Expenses:";
                            worksheet.Cells[row, 2].Value = totalExpenses;
                            worksheet.Cells[row, 2].Style.Font.Color.SetColor(System.Drawing.Color.Red);
                            worksheet.Cells[row, 2].Style.Font.Bold = true;

                            row++;
                            worksheet.Cells[row, 1].Value = "Balance:";
                            worksheet.Cells[row, 2].Value = balance;
                            worksheet.Cells[row, 2].Style.Font.Bold = true;
                            worksheet.Cells[row, 2].Style.Font.Color.SetColor(
                                balance >= 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red);

                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fileInfo);
                        }

                        MessageBox.Show($"Transactions exported successfully to:\n{saveFileDialog.FileName}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var result = MessageBox.Show("Do you want to open the file now?",
                            "Open File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = saveFileDialog.FileName,
                                UseShellExecute = true
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}