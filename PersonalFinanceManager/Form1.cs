using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            dgRecentTransactions.DataSource = DatabaseHelper.GetTransactions();
        }
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string category = cmbCategory.SelectedItem?.ToString() ?? "Other";
            double amount = Convert.ToDouble(txtAmount.Text);
            string type = rdoIncome.Checked ? "Income" : "Expense";
            string description = txtDescription.Text;

            DatabaseHelper.AddTransaction(date, category, amount, type, description);
            MessageBox.Show("Transaction Added Successfully!");

            LoadTransactions(); // Refresh transaction list
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgRecentTransactions.SelectedRows.Count > 0)
            {
                int transactionId = Convert.ToInt32(dgRecentTransactions.SelectedRows[0].Cells["Id"].Value);

                var confirmResult = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteTransaction(transactionId);
                    MessageBox.Show("Transaction deleted successfully!");
                    LoadTransactions(); // Refresh transaction list
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }

        private void btnUpdateTransaction_Click(object sender, EventArgs e)
        {
            if (btnAddTransaction.Tag == null)
            {
                MessageBox.Show("Error: No transaction selected for updating.");
                return;
            }

            int transactionId = (int)btnAddTransaction.Tag;
            string updatedDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string updatedCategory = cmbCategory.SelectedItem?.ToString() ?? "Other";
            double updatedAmount = Convert.ToDouble(txtAmount.Text);
            string updatedType = rdoIncome.Checked ? "Income" : "Expense";
            string updatedDescription = txtDescription.Text;

            DatabaseHelper.UpdateTransaction(transactionId, updatedDate, updatedCategory, updatedAmount, updatedType, updatedDescription);
            MessageBox.Show("Transaction updated successfully!");

            // Reset button text and remove event handler to avoid duplication
            btnAddTransaction.Text = "Add Transaction";
            btnAddTransaction.Tag = null;
            btnAddTransaction.Click -= btnUpdateTransaction_Click;
            btnAddTransaction.Click += btnAddTransaction_Click;

            LoadTransactions(); // Refresh data grid
        }

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            if (dgRecentTransactions.SelectedRows.Count > 0)
            {
                int transactionId = Convert.ToInt32(dgRecentTransactions.SelectedRows[0].Cells["Id"].Value);
                string date = dgRecentTransactions.SelectedRows[0].Cells["Date"].Value.ToString();
                string category = dgRecentTransactions.SelectedRows[0].Cells["Category"].Value.ToString();
                double amount = Convert.ToDouble(dgRecentTransactions.SelectedRows[0].Cells["Amount"].Value);
                string type = dgRecentTransactions.SelectedRows[0].Cells["Type"].Value.ToString();
                string description = dgRecentTransactions.SelectedRows[0].Cells["Description"].Value.ToString();

                // Populate input fields with existing values
                dtpDate.Value = DateTime.Parse(date);
                cmbCategory.SelectedItem = category;
                txtAmount.Text = amount.ToString();
                txtDescription.Text = description;

                if (type == "Income") rdoIncome.Checked = true;
                else rdoExpense.Checked = true;

                // Change button text to "Update Transaction"
                btnAddTransaction.Text = "Update Transaction";

                // Remove previous event handlers to prevent duplication
                btnAddTransaction.Click -= btnAddTransaction_Click;
                btnAddTransaction.Click -= btnUpdateTransaction_Click; // Ensure no duplicate handlers

                // Attach new event handler for updating
                btnAddTransaction.Click += btnUpdateTransaction_Click;

                // Save transaction ID in a hidden field or variable
                btnAddTransaction.Tag = transactionId;
            }
            else
            {
                MessageBox.Show("Please select a transaction to edit.");
            }
        }
    }
}
