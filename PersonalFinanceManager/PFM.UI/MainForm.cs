using PFM.Core.Entities;
using PFM.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

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
    }
}