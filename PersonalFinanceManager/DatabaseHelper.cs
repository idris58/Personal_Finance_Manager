using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Dapper;

namespace PersonalFinanceManager
{
    public class DatabaseHelper
    {
        private static readonly string dbFolderPath = "Database";
        private static readonly string dbPath = Path.Combine(dbFolderPath, "finance.db");
        private static readonly string connectionString = $"Data Source={dbPath};Version=3;";

        public static void InitializeDatabase()
        {
            // Ensure the Database folder exists
            if (!Directory.Exists(dbFolderPath))
            {
                Directory.CreateDirectory(dbFolderPath);
            }

            // Create database file if it doesn't exist
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTransactionsTable = @"
                CREATE TABLE IF NOT EXISTS Transactions (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Date TEXT NOT NULL,
                    Category TEXT NOT NULL,
                    Amount REAL NOT NULL,
                    Type TEXT NOT NULL,
                    Description TEXT
                );";

                string createCategoriesTable = @"
                CREATE TABLE IF NOT EXISTS Categories (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Type TEXT NOT NULL
                );";

                string createBudgetsTable = @"
                CREATE TABLE IF NOT EXISTS Budgets (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CategoryId INTEGER NOT NULL,
                    LimitAmount REAL NOT NULL,
                    Month TEXT NOT NULL,
                    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
                );";

                using (var command = new SQLiteCommand(createTransactionsTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createCategoriesTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createBudgetsTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void AddTransaction(string date, string category, double amount, string type, string description)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Transactions (Date, Category, Amount, Type, Description) VALUES (@date, @category, @amount, @type, @description)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@description", description);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetTransactions()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Transactions ORDER BY Date DESC";
                var dataAdapter = new SQLiteDataAdapter(query, connection);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }
        }

        public static void DeleteTransaction(int transactionId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Transactions WHERE Id = @id";
                connection.Execute(query, new { id = transactionId });
            }
        }

        public static void UpdateTransaction(int id, string date, string category, double amount, string type, string description)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"UPDATE Transactions 
                         SET Date = @date, Category = @category, Amount = @amount, Type = @type, Description = @description 
                         WHERE Id = @id";
                connection.Execute(query, new { id, date, category, amount, type, description });
            }
        }



    }
}
