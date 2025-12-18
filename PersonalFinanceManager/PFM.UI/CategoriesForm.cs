using PFM.Core.Entities;
using PFM.Core.Enums;
using PFM.Core.Interfaces;

namespace PFM.UI
{
    public partial class CategoriesForm : Form
    {
        private readonly IRepository<Category> _categoryRepository;
        private Category? _selectedCategory;

        public CategoriesForm(IRepository<Category> categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;

            InitializeForm();
        }

        private void InitializeForm()
        {
            radioBtnExpense.Checked = true;
            radioBtnExpense.Text = "Expense";
            radioBtnIncome.Text = "Income";

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            SetupDataGridView();
            LoadCategories();
        }

        private void SetupDataGridView()
        {
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.Columns.Clear();

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Visible = false
            });

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name",
                Width = 200
            });

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Description",
                DataPropertyName = "Description",
                Width = 350
            });

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Type",
                DataPropertyName = "Type",
                Width = 150
            });
        }

        private async void LoadCategories()
        {
            try
            {
                var categories = await _categoryRepository.GetAllAsync();
                dgvCategories.DataSource = categories.OrderBy(c => c.Name).ToList();

                dgvCategories.ClearSelection();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;

                var selectedRow = dgvCategories.SelectedRows[0];
                var categoryId = (int)selectedRow.Cells["Id"].Value;
                _selectedCategory = _categoryRepository.GetByIdAsync(categoryId).Result;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                _selectedCategory = null;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter category name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            try
            {
                if (_selectedCategory != null)
                {
                    _selectedCategory.Name = txtName.Text.Trim();
                    _selectedCategory.Description = txtDescription.Text.Trim();
                    _selectedCategory.Type = radioBtnIncome.Checked ?
                        TransactionType.Income : TransactionType.Expense;

                    await _categoryRepository.UpdateAsync(_selectedCategory);

                    MessageBox.Show("Category updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newCategory = new Category
                    {
                        Name = txtName.Text.Trim(),
                        Description = txtDescription.Text.Trim(),
                        Type = radioBtnIncome.Checked ?
                            TransactionType.Income : TransactionType.Expense,
                        Color = "#808080", 
                        CreatedAt = DateTime.Now
                    };

                    await _categoryRepository.AddAsync(newCategory);

                    MessageBox.Show("Category added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearForm();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving category: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtDescription.Clear();
            radioBtnExpense.Checked = true;
            _selectedCategory = null;
            dgvCategories.ClearSelection();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedCategory != null)
            {
                txtName.Text = _selectedCategory.Name;
                txtDescription.Text = _selectedCategory.Description;

                if (_selectedCategory.Type == TransactionType.Income)
                {
                    radioBtnIncome.Checked = true;
                }
                else
                {
                    radioBtnExpense.Checked = true;
                }

                txtName.Focus();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null)
            {
                MessageBox.Show("Please select a category to delete.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete the category '{_selectedCategory.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    await _categoryRepository.DeleteAsync(_selectedCategory);

                    MessageBox.Show("Category deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    LoadCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting category: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
