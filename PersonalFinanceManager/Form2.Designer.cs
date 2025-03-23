namespace PersonalFinanceManager
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnEditTransaction = new System.Windows.Forms.Button();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rdoExpense = new System.Windows.Forms.RadioButton();
            this.rdoIncome = new System.Windows.Forms.RadioButton();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Catagory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Amount";
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(670, 313);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteTransaction.TabIndex = 45;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // btnEditTransaction
            // 
            this.btnEditTransaction.Location = new System.Drawing.Point(540, 313);
            this.btnEditTransaction.Name = "btnEditTransaction";
            this.btnEditTransaction.Size = new System.Drawing.Size(104, 23);
            this.btnEditTransaction.TabIndex = 44;
            this.btnEditTransaction.Text = "Edit Transaction";
            this.btnEditTransaction.UseVisualStyleBackColor = true;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(421, 24);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(400, 279);
            this.dgvTransactions.TabIndex = 43;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(192, 292);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(116, 23);
            this.btnAddTransaction.TabIndex = 42;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(152, 192);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 84);
            this.txtDescription.TabIndex = 41;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(152, 166);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 40;
            // 
            // rdoExpense
            // 
            this.rdoExpense.AutoSize = true;
            this.rdoExpense.Location = new System.Drawing.Point(268, 134);
            this.rdoExpense.Name = "rdoExpense";
            this.rdoExpense.Size = new System.Drawing.Size(66, 17);
            this.rdoExpense.TabIndex = 39;
            this.rdoExpense.TabStop = true;
            this.rdoExpense.Text = "Expense";
            this.rdoExpense.UseVisualStyleBackColor = true;
            // 
            // rdoIncome
            // 
            this.rdoIncome.AutoSize = true;
            this.rdoIncome.Location = new System.Drawing.Point(177, 134);
            this.rdoIncome.Name = "rdoIncome";
            this.rdoIncome.Size = new System.Drawing.Size(60, 17);
            this.rdoIncome.TabIndex = 38;
            this.rdoIncome.TabStop = true;
            this.rdoIncome.Text = "Income";
            this.rdoIncome.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(192, 87);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(133, 21);
            this.cmbCategory.TabIndex = 37;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(192, 40);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 20);
            this.txtAmount.TabIndex = 36;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 464);
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
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Button btnEditTransaction;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rdoExpense;
        private System.Windows.Forms.RadioButton rdoIncome;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtAmount;
    }
}