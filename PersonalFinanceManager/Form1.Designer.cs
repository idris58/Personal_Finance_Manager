namespace PersonalFinanceManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBudgets = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.dgRecentTransactions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartSpending = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnEditTransaction = new System.Windows.Forms.Button();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rdoExpense = new System.Windows.Forms.RadioButton();
            this.rdoIncome = new System.Windows.Forms.RadioButton();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecentTransactions)).BeginInit();
            this.pnlTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 472);
            this.panelMenu.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Location = new System.Drawing.Point(0, 309);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel5.Size = new System.Drawing.Size(220, 44);
            this.panel5.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-9, -12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(241, 69);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(220, 44);
            this.panel1.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-9, -12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(241, 69);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReports);
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel4.Size = new System.Drawing.Size(220, 44);
            this.panel4.TabIndex = 4;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(-9, -12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(241, 69);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "          Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTransactions);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Size = new System.Drawing.Size(220, 44);
            this.panel2.TabIndex = 3;
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(-9, -12);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTransactions.Size = new System.Drawing.Size(241, 69);
            this.btnTransactions.TabIndex = 1;
            this.btnTransactions.Text = "          Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBudgets);
            this.panel3.Location = new System.Drawing.Point(0, 183);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel3.Size = new System.Drawing.Size(220, 44);
            this.panel3.TabIndex = 3;
            // 
            // btnBudgets
            // 
            this.btnBudgets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnBudgets.FlatAppearance.BorderSize = 0;
            this.btnBudgets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudgets.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBudgets.Image = ((System.Drawing.Image)(resources.GetObject("btnBudgets.Image")));
            this.btnBudgets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBudgets.Location = new System.Drawing.Point(-9, -12);
            this.btnBudgets.Name = "btnBudgets";
            this.btnBudgets.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBudgets.Size = new System.Drawing.Size(241, 69);
            this.btnBudgets.TabIndex = 1;
            this.btnBudgets.Text = "          Budgets";
            this.btnBudgets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBudgets.UseVisualStyleBackColor = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDashboard.Controls.Add(this.pnlTransactions);
            this.pnlDashboard.Controls.Add(this.chartSpending);
            this.pnlDashboard.Controls.Add(this.label3);
            this.pnlDashboard.Controls.Add(this.label2);
            this.pnlDashboard.Controls.Add(this.label1);
            this.pnlDashboard.Controls.Add(this.dgRecentTransactions);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(220, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(723, 472);
            this.pnlDashboard.TabIndex = 1;
            // 
            // dgRecentTransactions
            // 
            this.dgRecentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecentTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgRecentTransactions.Location = new System.Drawing.Point(311, 24);
            this.dgRecentTransactions.Name = "dgRecentTransactions";
            this.dgRecentTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRecentTransactions.Size = new System.Drawing.Size(400, 279);
            this.dgRecentTransactions.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            // 
            // chartSpending
            // 
            this.chartSpending.Location = new System.Drawing.Point(37, 153);
            this.chartSpending.Name = "chartSpending";
            this.chartSpending.Size = new System.Drawing.Size(241, 200);
            this.chartSpending.TabIndex = 42;
            this.chartSpending.Text = "elementHost1";
            this.chartSpending.Child = this.cartesianChart1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Balance: $0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Total Expenses: $0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Total Income: $0";
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.label4);
            this.pnlTransactions.Controls.Add(this.label5);
            this.pnlTransactions.Controls.Add(this.btnDeleteTransaction);
            this.pnlTransactions.Controls.Add(this.btnEditTransaction);
            this.pnlTransactions.Controls.Add(this.dgTransactions);
            this.pnlTransactions.Controls.Add(this.btnAddTransaction);
            this.pnlTransactions.Controls.Add(this.txtDescription);
            this.pnlTransactions.Controls.Add(this.dtpDate);
            this.pnlTransactions.Controls.Add(this.rdoExpense);
            this.pnlTransactions.Controls.Add(this.rdoIncome);
            this.pnlTransactions.Controls.Add(this.cmbCategory);
            this.pnlTransactions.Controls.Add(this.txtAmount);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 0);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(723, 472);
            this.pnlTransactions.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Catagory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Amount";
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(560, 346);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteTransaction.TabIndex = 57;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.Location = new System.Drawing.Point(430, 346);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(104, 23);
            this.btnEditTransaction.TabIndex = 56;
            this.btnEditTransaction.Text = "Edit Transaction";
            this.btnEditTransaction.UseVisualStyleBackColor = true;
            // 
            // dgTransactions
            // 
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Location = new System.Drawing.Point(311, 57);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransactions.Size = new System.Drawing.Size(400, 279);
            this.dgTransactions.TabIndex = 55;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(82, 325);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(116, 23);
            this.btnAddTransaction.TabIndex = 54;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(42, 225);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 84);
            this.txtDescription.TabIndex = 53;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(42, 199);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 52;
            // 
            // rdoExpense
            // 
            this.rdoExpense.AutoSize = true;
            this.rdoExpense.Location = new System.Drawing.Point(158, 167);
            this.rdoExpense.Name = "rdoExpense";
            this.rdoExpense.Size = new System.Drawing.Size(66, 17);
            this.rdoExpense.TabIndex = 51;
            this.rdoExpense.TabStop = true;
            this.rdoExpense.Text = "Expense";
            this.rdoExpense.UseVisualStyleBackColor = true;
            // 
            // rdoIncome
            // 
            this.rdoIncome.AutoSize = true;
            this.rdoIncome.Location = new System.Drawing.Point(67, 167);
            this.rdoIncome.Name = "rdoIncome";
            this.rdoIncome.Size = new System.Drawing.Size(60, 17);
            this.rdoIncome.TabIndex = 50;
            this.rdoIncome.TabStop = true;
            this.rdoIncome.Text = "Income";
            this.rdoIncome.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(82, 120);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(133, 21);
            this.cmbCategory.TabIndex = 49;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(82, 73);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 20);
            this.txtAmount.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 472);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecentTransactions)).EndInit();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBudgets;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.DataGridView dgRecentTransactions;
        private System.Windows.Forms.Integration.ElementHost chartSpending;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Button btnEditTransaction;
        private System.Windows.Forms.DataGridView dgTransactions;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rdoExpense;
        private System.Windows.Forms.RadioButton rdoIncome;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

