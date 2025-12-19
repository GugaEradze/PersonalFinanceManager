namespace PFM.UI
{
    partial class MonthlyReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelInfo = new Panel();
            lblBalance = new Label();
            lblTotalExpenses = new Label();
            lblTotalIncome = new Label();
            panelChart = new Panel();
            chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelMain = new Panel();
            panelAdd = new Panel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            dtpMonth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnLoadReport = new Guna.UI2.WinForms.Guna2Button();
            labelSelectMonth = new Label();
            panelHeader = new Panel();
            labelHeader = new Label();
            panelInfo.SuspendLayout();
            panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartReport).BeginInit();
            panelMain.SuspendLayout();
            panelAdd.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(lblBalance);
            panelInfo.Controls.Add(lblTotalExpenses);
            panelInfo.Controls.Add(lblTotalIncome);
            panelInfo.Location = new Point(38, 845);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1775, 66);
            panelInfo.TabIndex = 5;
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.SteelBlue;
            lblBalance.Location = new Point(1539, 11);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(233, 45);
            lblBalance.TabIndex = 5;
            lblBalance.Text = "Balance : 0.00 ₾";
            lblBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalExpenses.ForeColor = Color.Red;
            lblTotalExpenses.Location = new Point(733, 11);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(309, 45);
            lblTotalExpenses.TabIndex = 4;
            lblTotalExpenses.Text = "Total Expenses : 0.00 ₾";
            lblTotalExpenses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = Color.ForestGreen;
            lblTotalIncome.Location = new Point(3, 11);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(293, 45);
            lblTotalIncome.TabIndex = 3;
            lblTotalIncome.Text = "Total Income : 0.00 ₾";
            lblTotalIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelChart
            // 
            panelChart.Controls.Add(chartReport);
            panelChart.Location = new Point(38, 193);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(1775, 630);
            panelChart.TabIndex = 4;
            // 
            // chartReport
            // 
            chartArea1.Name = "ChartArea1";
            chartReport.ChartAreas.Add(chartArea1);
            chartReport.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartReport.Legends.Add(legend1);
            chartReport.Location = new Point(0, 0);
            chartReport.Name = "chartReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartReport.Series.Add(series1);
            chartReport.Size = new Size(1775, 630);
            chartReport.TabIndex = 0;
            chartReport.Text = "chart1";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelAdd);
            panelMain.Controls.Add(panelHeader);
            panelMain.Location = new Point(38, 38);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1775, 132);
            panelMain.TabIndex = 3;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(btnClose);
            panelAdd.Controls.Add(dtpMonth);
            panelAdd.Controls.Add(btnLoadReport);
            panelAdd.Controls.Add(labelSelectMonth);
            panelAdd.Dock = DockStyle.Fill;
            panelAdd.Location = new Point(0, 49);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(1775, 83);
            panelAdd.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 10;
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Silver;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1613, 18);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(144, 50);
            btnClose.TabIndex = 11;
            btnClose.Text = "Cancel";
            btnClose.Click += btnClose_Click;
            // 
            // dtpMonth
            // 
            dtpMonth.Checked = true;
            dtpMonth.CustomFormat = "MMMM yyyy";
            dtpMonth.CustomizableEdges = customizableEdges3;
            dtpMonth.Font = new Font("Segoe UI", 9F);
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(217, 18);
            dtpMonth.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpMonth.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpMonth.Size = new Size(333, 38);
            dtpMonth.TabIndex = 9;
            dtpMonth.Value = new DateTime(2025, 12, 19, 19, 14, 23, 126);
            // 
            // btnLoadReport
            // 
            btnLoadReport.BorderRadius = 10;
            btnLoadReport.CustomizableEdges = customizableEdges5;
            btnLoadReport.DisabledState.BorderColor = Color.DarkGray;
            btnLoadReport.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLoadReport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLoadReport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLoadReport.FillColor = SystemColors.MenuHighlight;
            btnLoadReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadReport.ForeColor = Color.White;
            btnLoadReport.Location = new Point(1390, 18);
            btnLoadReport.Name = "btnLoadReport";
            btnLoadReport.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLoadReport.Size = new Size(200, 38);
            btnLoadReport.TabIndex = 7;
            btnLoadReport.Text = "Load Report";
            btnLoadReport.Click += btnLoadReport_Click;
            // 
            // labelSelectMonth
            // 
            labelSelectMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSelectMonth.Location = new Point(15, 18);
            labelSelectMonth.Name = "labelSelectMonth";
            labelSelectMonth.Size = new Size(196, 38);
            labelSelectMonth.TabIndex = 0;
            labelSelectMonth.Text = "Select Month :";
            labelSelectMonth.TextAlign = ContentAlignment.MiddleLeft;
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
            labelHeader.Text = "Monthly Report";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MonthlyReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1851, 948);
            Controls.Add(panelInfo);
            Controls.Add(panelChart);
            Controls.Add(panelMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MonthlyReportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Monthly Report";
            panelInfo.ResumeLayout(false);
            panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartReport).EndInit();
            panelMain.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private Panel panelMain;
        private Panel panelAdd;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMonth;
        private Guna.UI2.WinForms.Guna2Button btnLoadReport;
        private Label labelSelectMonth;
        private Panel panelHeader;
        private Label labelHeader;
        private Label lblBalance;
        private Label lblTotalExpenses;
        private Label lblTotalIncome;
    }
}