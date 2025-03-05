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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rdoIncome = new System.Windows.Forms.RadioButton();
            this.rdoExpense = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnEditTransaction = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(105, 90);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 20);
            this.txtAmount.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(105, 137);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(133, 21);
            this.cmbCategory.TabIndex = 1;
            // 
            // rdoIncome
            // 
            this.rdoIncome.AutoSize = true;
            this.rdoIncome.Location = new System.Drawing.Point(90, 184);
            this.rdoIncome.Name = "rdoIncome";
            this.rdoIncome.Size = new System.Drawing.Size(60, 17);
            this.rdoIncome.TabIndex = 2;
            this.rdoIncome.TabStop = true;
            this.rdoIncome.Text = "Income";
            this.rdoIncome.UseVisualStyleBackColor = true;
            // 
            // rdoExpense
            // 
            this.rdoExpense.AutoSize = true;
            this.rdoExpense.Location = new System.Drawing.Point(181, 184);
            this.rdoExpense.Name = "rdoExpense";
            this.rdoExpense.Size = new System.Drawing.Size(66, 17);
            this.rdoExpense.TabIndex = 3;
            this.rdoExpense.TabStop = true;
            this.rdoExpense.Text = "Expense";
            this.rdoExpense.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(65, 216);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(65, 242);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 84);
            this.txtDescription.TabIndex = 5;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(105, 342);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(100, 23);
            this.btnAddTransaction.TabIndex = 6;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(295, 64);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(585, 279);
            this.dgvTransactions.TabIndex = 7;
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.Location = new System.Drawing.Point(453, 363);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(104, 23);
            this.btnEditTransaction.TabIndex = 8;
            this.btnEditTransaction.Text = "Edit Transaction";
            this.btnEditTransaction.UseVisualStyleBackColor = true;
            this.btnEditTransaction.Click += new System.EventHandler(this.btnEditTransaction_Click);
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(583, 363);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteTransaction.TabIndex = 9;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Catagory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.btnEditTransaction);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.rdoExpense);
            this.Controls.Add(this.rdoIncome);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RadioButton rdoIncome;
        private System.Windows.Forms.RadioButton rdoExpense;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnEditTransaction;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

