namespace PFM.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMain = new Panel();
            panelBottom = new Panel();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            dgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            panelMid = new Panel();
            lblBalance = new Label();
            lblTotalExpenses = new Label();
            lblTotalIncome = new Label();
            filterPanel = new Panel();
            cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            dtpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnAddTransaction = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            menuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            addTransactionToolStripMenuItem = new ToolStripMenuItem();
            viewAllToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            manageCategoriesToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            monthlyReportToolStripMenuItem = new ToolStripMenuItem();
            categoryAnalysisToolStripMenuItem = new ToolStripMenuItem();
            panelMain.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panelMid.SuspendLayout();
            filterPanel.SuspendLayout();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelBottom);
            panelMain.Controls.Add(dgvTransactions);
            panelMain.Controls.Add(panelMid);
            panelMain.Controls.Add(filterPanel);
            panelMain.Controls.Add(menuMain);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1851, 948);
            panelMain.TabIndex = 0;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnExport);
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Controls.Add(btnEdit);
            panelBottom.Location = new Point(24, 836);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1802, 90);
            panelBottom.TabIndex = 3;
            // 
            // btnExport
            // 
            btnExport.BorderRadius = 15;
            btnExport.CustomizableEdges = customizableEdges1;
            btnExport.DisabledState.BorderColor = Color.DarkGray;
            btnExport.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExport.FillColor = Color.ForestGreen;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(1054, 17);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExport.Size = new Size(264, 58);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export To Excel";
            btnExport.Click += btnExport_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 15;
            btnDelete.CustomizableEdges = customizableEdges3;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(773, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDelete.Size = new Size(264, 58);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderRadius = 15;
            btnEdit.CustomizableEdges = customizableEdges5;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = SystemColors.MenuHighlight;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(492, 17);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEdit.Size = new Size(264, 58);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvTransactions
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransactions.ColumnHeadersHeight = 4;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransactions.GridColor = Color.FromArgb(231, 229, 255);
            dgvTransactions.Location = new Point(24, 272);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.Size = new Size(1802, 547);
            dgvTransactions.TabIndex = 2;
            dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTransactions.ThemeStyle.BackColor = Color.White;
            dgvTransactions.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTransactions.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTransactions.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvTransactions.ThemeStyle.HeaderStyle.Height = 4;
            dgvTransactions.ThemeStyle.ReadOnly = false;
            dgvTransactions.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransactions.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTransactions.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTransactions.ThemeStyle.RowsStyle.Height = 33;
            dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTransactions.SelectionChanged += dgvTransactions_SelectionChanged;
            // 
            // panelMid
            // 
            panelMid.BorderStyle = BorderStyle.FixedSingle;
            panelMid.Controls.Add(lblBalance);
            panelMid.Controls.Add(lblTotalExpenses);
            panelMid.Controls.Add(lblTotalIncome);
            panelMid.Location = new Point(24, 182);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1802, 71);
            panelMid.TabIndex = 1;
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.SteelBlue;
            lblBalance.Location = new Point(1552, 14);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(233, 45);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Balance : 0.00 ₾";
            lblBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalExpenses.ForeColor = Color.Red;
            lblTotalExpenses.Location = new Point(746, 14);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(309, 45);
            lblTotalExpenses.TabIndex = 1;
            lblTotalExpenses.Text = "Total Expenses : 0.00 ₾";
            lblTotalExpenses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = Color.ForestGreen;
            lblTotalIncome.Location = new Point(16, 14);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(293, 45);
            lblTotalIncome.TabIndex = 0;
            lblTotalIncome.Text = "Total Income : 0.00 ₾";
            lblTotalIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // filterPanel
            // 
            filterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(cmbType);
            filterPanel.Controls.Add(dtpToDate);
            filterPanel.Controls.Add(dtpFromDate);
            filterPanel.Controls.Add(btnRefresh);
            filterPanel.Controls.Add(btnAddTransaction);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Location = new Point(24, 45);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1802, 114);
            filterPanel.TabIndex = 0;
            // 
            // cmbType
            // 
            cmbType.BackColor = Color.Transparent;
            cmbType.BorderRadius = 15;
            cmbType.CustomizableEdges = customizableEdges7;
            cmbType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbType.ForeColor = Color.FromArgb(68, 88, 112);
            cmbType.ItemHeight = 28;
            cmbType.Location = new Point(760, 26);
            cmbType.Name = "cmbType";
            cmbType.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbType.Size = new Size(216, 34);
            cmbType.TabIndex = 5;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // dtpToDate
            // 
            dtpToDate.BorderRadius = 15;
            dtpToDate.Checked = true;
            dtpToDate.CustomizableEdges = customizableEdges9;
            dtpToDate.FillColor = Color.White;
            dtpToDate.Font = new Font("Segoe UI", 12F);
            dtpToDate.Format = DateTimePickerFormat.Long;
            dtpToDate.Location = new Point(1396, 25);
            dtpToDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpToDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtpToDate.Size = new Size(389, 58);
            dtpToDate.TabIndex = 4;
            dtpToDate.Value = new DateTime(2025, 12, 18, 2, 35, 45, 514);
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;
            // 
            // dtpFromDate
            // 
            dtpFromDate.BorderRadius = 15;
            dtpFromDate.Checked = true;
            dtpFromDate.CustomizableEdges = customizableEdges11;
            dtpFromDate.FillColor = Color.White;
            dtpFromDate.Font = new Font("Segoe UI", 12F);
            dtpFromDate.Format = DateTimePickerFormat.Long;
            dtpFromDate.Location = new Point(988, 26);
            dtpFromDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFromDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.ShadowDecoration.CustomizableEdges = customizableEdges12;
            dtpFromDate.Size = new Size(396, 58);
            dtpFromDate.TabIndex = 3;
            dtpFromDate.Value = new DateTime(2025, 12, 18, 2, 35, 45, 514);
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 15;
            btnRefresh.CustomizableEdges = customizableEdges13;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.DarkGray;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(262, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnRefresh.Size = new Size(197, 58);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.BorderRadius = 15;
            btnAddTransaction.CustomizableEdges = customizableEdges15;
            btnAddTransaction.DisabledState.BorderColor = Color.DarkGray;
            btnAddTransaction.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddTransaction.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddTransaction.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddTransaction.FillColor = SystemColors.MenuHighlight;
            btnAddTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTransaction.ForeColor = Color.White;
            btnAddTransaction.Location = new Point(12, 25);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnAddTransaction.Size = new Size(243, 58);
            btnAddTransaction.TabIndex = 1;
            btnAddTransaction.Text = "Add Transaction";
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 15;
            txtSearch.CustomizableEdges = customizableEdges17;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(470, 26);
            txtSearch.Margin = new Padding(11, 13, 11, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtSearch.Size = new Size(279, 57);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(24, 24);
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, transactionsToolStripMenuItem, categoriesToolStripMenuItem, reportsToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(1851, 33);
            menuMain.TabIndex = 4;
            menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTransactionToolStripMenuItem, viewAllToolStripMenuItem });
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(124, 29);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // addTransactionToolStripMenuItem
            // 
            addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            addTransactionToolStripMenuItem.Size = new Size(241, 34);
            addTransactionToolStripMenuItem.Text = "Add Transaction";
            addTransactionToolStripMenuItem.Click += addTransactionToolStripMenuItem_Click;
            // 
            // viewAllToolStripMenuItem
            // 
            viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            viewAllToolStripMenuItem.Size = new Size(241, 34);
            viewAllToolStripMenuItem.Text = "View All";
            viewAllToolStripMenuItem.Click += viewAllToolStripMenuItem_Click;
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageCategoriesToolStripMenuItem });
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(112, 29);
            categoriesToolStripMenuItem.Text = "Categories";
            // 
            // manageCategoriesToolStripMenuItem
            // 
            manageCategoriesToolStripMenuItem.Name = "manageCategoriesToolStripMenuItem";
            manageCategoriesToolStripMenuItem.Size = new Size(267, 34);
            manageCategoriesToolStripMenuItem.Text = "Manage Categories";
            manageCategoriesToolStripMenuItem.Click += manageCategoriesToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { monthlyReportToolStripMenuItem, categoryAnalysisToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(89, 29);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // monthlyReportToolStripMenuItem
            // 
            monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            monthlyReportToolStripMenuItem.Size = new Size(255, 34);
            monthlyReportToolStripMenuItem.Text = "Monthly Report";
            // 
            // categoryAnalysisToolStripMenuItem
            // 
            categoryAnalysisToolStripMenuItem.Name = "categoryAnalysisToolStripMenuItem";
            categoryAnalysisToolStripMenuItem.Size = new Size(255, 34);
            categoryAnalysisToolStripMenuItem.Text = "Category Analysis";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1851, 948);
            Controls.Add(panelMain);
            MainMenuStrip = menuMain;
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Finance Manager";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panelMid.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel filterPanel;
        private Guna.UI2.WinForms.Guna2Button btnAddTransaction;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFromDate;
        private Panel panelMid;
        private Label lblTotalIncome;
        private Label lblBalance;
        private Label lblTotalExpenses;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactions;
        private Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2ComboBox cmbType;
        private MenuStrip menuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem addTransactionToolStripMenuItem;
        private ToolStripMenuItem viewAllToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem manageCategoriesToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem monthlyReportToolStripMenuItem;
        private ToolStripMenuItem categoryAnalysisToolStripMenuItem;
    }
}
