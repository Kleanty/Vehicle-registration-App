using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace aracKayitApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string databasePath = Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db";

            InitializeDatabase(databasePath);
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginScreen());
        }

        private static void InitializeDatabase(string databasePath)
        {
            CreateDatabaseIfNotExists(databasePath);
            EnsureAdminUserExists(databasePath, "ADMIN", "ADMIN");
        }

        private static void CreateDatabaseIfNotExists(string databasePath)
        {
            if (!System.IO.File.Exists(databasePath))
            {
                SQLiteConnection.CreateFile(databasePath);
            }

            using (var connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();
                CreateCustomersTable(connection);
                CreateUsersTable(connection);
                CreateAdminsTable(connection);
            }
        }

        private static void CreateCustomersTable(SQLiteConnection connection)
        {
            ExecuteNonQuery(connection, @"
                CREATE TABLE IF NOT EXISTS Customers (
                    Id INTEGER PRIMARY KEY,
                    Name TEXT NOT NULL,
                    TelNo TEXT NOT NULL,
                    Plaka TEXT NOT NULL,
                    Models TEXT NOT NULL,
                    Tarih_ve_Zaman TEXT NOT NULL,
                    Ariza TEXT NOT NULL,
                    CustomerNumber INTEGER NOT NULL UNIQUE
                )");
        }

        private static void CreateUsersTable(SQLiteConnection connection)
        {
            ExecuteNonQuery(connection, @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY,
                    NickName TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL UNIQUE
                )");
        }

        private static void CreateAdminsTable(SQLiteConnection connection)
        {
            ExecuteNonQuery(connection, @"
                CREATE TABLE IF NOT EXISTS Admins (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NickName TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL UNIQUE
                )");
        }

        private static void EnsureAdminUserExists(string databasePath, string adminName, string adminPassword)
        {
            using (var connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Admins WHERE NickName = @Name";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", adminName);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 0)
                    {
                        string insertQuery = "INSERT INTO Admins (NickName, Password) VALUES (@Name, @Password)";
                        using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Name", adminName);
                            insertCommand.Parameters.AddWithValue("@Password", adminPassword);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private static void ExecuteNonQuery(SQLiteConnection connection, string query)
        {
            using (var command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
