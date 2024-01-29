using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace aracKayitApp
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            string enteredUserName = nickNameTextBox.Text.ToUpper();
            string enteredPassword = passwodTextBox.Text.ToUpper();

            if (IsLoginValid(enteredUserName, enteredPassword, "Users"))
            {
                OpenMainScreen();
            }
            else
            {
                ShowLoginError();
            }
        }

        private void AdminBut_Click(object sender, EventArgs e)
        {
            string enteredUserName = nickNameTextBox.Text.ToUpper();
            string enteredPassword = passwodTextBox.Text.ToUpper();

            if (IsLoginValid(enteredUserName, enteredPassword, "Admins"))
            {
                OpenAdminScreen();
            }
            else
            {
                ShowLoginError();
            }
        }

        private bool IsLoginValid(string userName, string password, string tableName)
        {
            string connectionString = "Data Source=" + Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string queryText = $"SELECT COUNT(*) FROM {tableName} WHERE UPPER(NickName) = @NickName AND UPPER(Password) = @Password";

                using (SQLiteCommand queryCommand = new SQLiteCommand(queryText, connection))
                {
                    queryCommand.Parameters.AddWithValue("@NickName", userName);
                    queryCommand.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(queryCommand.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void OpenMainScreen()
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void OpenAdminScreen()
        {
            AdminScreen adminScreen = new AdminScreen();
            adminScreen.Show();
            this.Hide();
        }

        private void ShowLoginError()
        {
            MessageBox.Show("Hatalı kullanıcı adı veya şifre. Tekrar deneyin.");
        }
    }
}
