using PFM.Core.Entities;
using PFM.Core.Enums;
using PFM.Core.Interfaces;

namespace PFM.UI
{
    public partial class AddEditTransactionForm : Form
    {
        private readonly IRepository<Transaction> _transactionRepository;
        private readonly IRepository<Category> _categoryRepository;
        private Transaction? _transactionToEdit;
        private bool _isEditMode;

        public AddEditTransactionForm(
            IRepository<Transaction> transactionRepository,
            IRepository<Category> categoryRepository,
            Transaction? transaction = null)
        {
            InitializeComponent();
            _transactionRepository = transactionRepository;
            _categoryRepository = categoryRepository;
            _transactionToEdit = transaction;
            _isEditMode = transaction != null;

            LoadForm();
        }

        private async void LoadForm()
        {
            var categories = await _categoryRepository.GetAllAsync();
            cmbCategory.Items.Clear();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = categories.ToList();

            if (_isEditMode && _transactionToEdit != null)
            {
                this.Text = "Edit Transaction";
                txtAmount.Text = _transactionToEdit.Amount.ToString();
                txtDescription.Text = _transactionToEdit.Description;
                cmbCategory.SelectedValue = _transactionToEdit.CategoryId;
                dtpDate.Value = _transactionToEdit.Date;

                if (_transactionToEdit.Type == TransactionType.Income)
                {
                    radioBtnIncome.Checked = true;
                }
                else
                {
                    radioBtnExpense.Checked = true;
                }
            }
            else
            {
                this.Text = "Add Transaction";
                dtpDate.Value = DateTime.Now;
                radioBtnExpense.Checked = true;
            }
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter description.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_isEditMode && _transactionToEdit != null)
                {
                    _transactionToEdit.Amount = amount;
                    _transactionToEdit.Description = txtDescription.Text.Trim();
                    _transactionToEdit.CategoryId = (int)cmbCategory.SelectedValue;
                    _transactionToEdit.Date = dtpDate.Value;
                    _transactionToEdit.Type = radioBtnIncome.Checked ?
                        TransactionType.Income : TransactionType.Expense;

                    await _transactionRepository.UpdateAsync(_transactionToEdit);

                    MessageBox.Show("Transaction updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newTransaction = new Transaction
                    {
                        Amount = amount,
                        Description = txtDescription.Text.Trim(),
                        CategoryId = (int)cmbCategory.SelectedValue,
                        Date = dtpDate.Value,
                        Type = radioBtnIncome.Checked ?
                            TransactionType.Income : TransactionType.Expense,
                        Currency = "GEL",
                        CreatedAt = DateTime.Now
                    };

                    await _transactionRepository.AddAsync(newTransaction);

                    MessageBox.Show("Transaction added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving transaction: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}