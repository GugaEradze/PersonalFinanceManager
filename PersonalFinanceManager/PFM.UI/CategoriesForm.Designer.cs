namespace PFM.UI
{
    partial class CategoriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMain = new Panel();
            panelAdd = new Panel();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            radioBtnExpense = new RadioButton();
            radioBtnIncome = new RadioButton();
            txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            labelType = new Label();
            labelDescription = new Label();
            labelName = new Label();
            panelHeader = new Panel();
            labelHeader = new Label();
            panelData = new Panel();
            dgvCategories = new Guna.UI2.WinForms.Guna2DataGridView();
            panelButton = new Panel();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            panelMain.SuspendLayout();
            panelAdd.SuspendLayout();
            panelHeader.SuspendLayout();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            panelButton.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelAdd);
            panelMain.Controls.Add(panelHeader);
            panelMain.Location = new Point(38, 36);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1775, 313);
            panelMain.TabIndex = 0;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(btnClear);
            panelAdd.Controls.Add(btnSave);
            panelAdd.Controls.Add(radioBtnExpense);
            panelAdd.Controls.Add(radioBtnIncome);
            panelAdd.Controls.Add(txtDescription);
            panelAdd.Controls.Add(txtName);
            panelAdd.Controls.Add(labelType);
            panelAdd.Controls.Add(labelDescription);
            panelAdd.Controls.Add(labelName);
            panelAdd.Dock = DockStyle.Fill;
            panelAdd.Location = new Point(0, 49);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(1775, 264);
            panelAdd.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BorderRadius = 10;
            btnClear.CustomizableEdges = customizableEdges1;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.Silver;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1590, 200);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClear.Size = new Size(144, 50);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 10;
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = SystemColors.MenuHighlight;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1423, 200);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(144, 50);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // radioBtnExpense
            // 
            radioBtnExpense.AutoSize = true;
            radioBtnExpense.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnExpense.Location = new Point(456, 136);
            radioBtnExpense.Name = "radioBtnExpense";
            radioBtnExpense.Size = new Size(191, 36);
            radioBtnExpense.TabIndex = 6;
            radioBtnExpense.TabStop = true;
            radioBtnExpense.Text = "radioButton2";
            radioBtnExpense.UseVisualStyleBackColor = true;
            // 
            // radioBtnIncome
            // 
            radioBtnIncome.AutoSize = true;
            radioBtnIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnIncome.Location = new Point(246, 136);
            radioBtnIncome.Name = "radioBtnIncome";
            radioBtnIncome.Size = new Size(124, 36);
            radioBtnIncome.TabIndex = 5;
            radioBtnIncome.TabStop = true;
            radioBtnIncome.Text = "Income";
            radioBtnIncome.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.CustomizableEdges = customizableEdges5;
            txtDescription.DefaultText = "";
            txtDescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Font = new Font("Segoe UI", 9F);
            txtDescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Location = new Point(246, 75);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "";
            txtDescription.SelectedText = "";
            txtDescription.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtDescription.Size = new Size(1488, 38);
            txtDescription.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(246, 18);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(1488, 38);
            txtName.TabIndex = 3;
            // 
            // labelType
            // 
            labelType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelType.Location = new Point(15, 134);
            labelType.Name = "labelType";
            labelType.Size = new Size(165, 38);
            labelType.TabIndex = 2;
            labelType.Text = "Type :";
            labelType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            labelDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(15, 75);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(165, 38);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Description :";
            labelDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(15, 18);
            labelName.Name = "labelName";
            labelName.Size = new Size(165, 38);
            labelName.TabIndex = 0;
            labelName.Text = "Name : ";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ScrollBar;
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1775, 49);
            panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(15, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(249, 49);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Add / Edit";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelData
            // 
            panelData.Controls.Add(dgvCategories);
            panelData.Location = new Point(38, 370);
            panelData.Name = "panelData";
            panelData.Size = new Size(1775, 451);
            panelData.TabIndex = 1;
            // 
            // dgvCategories
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.ColumnHeadersHeight = 4;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategories.Location = new Point(0, 0);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 62;
            dgvCategories.Size = new Size(1775, 451);
            dgvCategories.TabIndex = 0;
            dgvCategories.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCategories.ThemeStyle.BackColor = Color.White;
            dgvCategories.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCategories.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCategories.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategories.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvCategories.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCategories.ThemeStyle.HeaderStyle.Height = 4;
            dgvCategories.ThemeStyle.ReadOnly = false;
            dgvCategories.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCategories.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategories.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvCategories.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCategories.ThemeStyle.RowsStyle.Height = 33;
            dgvCategories.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCategories.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            // 
            // panelButton
            // 
            panelButton.Controls.Add(btnCancel);
            panelButton.Controls.Add(btnDelete);
            panelButton.Controls.Add(btnEdit);
            panelButton.Location = new Point(38, 843);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(1775, 66);
            panelButton.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 10;
            btnCancel.CustomizableEdges = customizableEdges9;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.Silver;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(990, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancel.Size = new Size(144, 50);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 10;
            btnDelete.CustomizableEdges = customizableEdges11;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(816, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDelete.Size = new Size(144, 50);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 10;
            btnEdit.CustomizableEdges = customizableEdges13;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = SystemColors.MenuHighlight;
            btnEdit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(642, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnEdit.Size = new Size(144, 50);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1851, 948);
            Controls.Add(panelButton);
            Controls.Add(panelData);
            Controls.Add(panelMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Categories";
            panelMain.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            panelButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelAdd;
        private Label labelName;
        private Panel panelHeader;
        private Label labelHeader;
        private Panel panelData;
        private Label labelType;
        private Label labelDescription;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private RadioButton radioBtnExpense;
        private RadioButton radioBtnIncome;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategories;
        private Panel panelButton;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
    }
}