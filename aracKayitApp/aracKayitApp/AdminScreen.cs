using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKayitApp
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BackAppBut_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void DBadderBut_Click(object sender, EventArgs e)
        {



            string userName = UserNameTextBox.Text.ToUpper(); // Kullanıcı adını büyük harfle dönüştür
            string password = UserPassTextBox.Text.ToUpper(); // Şifreyi büyük harfle dönüştür

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                // Kullanıcı adı ve şifre veritabanına eklemek için sorguyu oluşturun
                string insertQuery = "INSERT INTO Users (NickName, Password) VALUES (@UserName, @Password)";
                string connectionString = "Data Source=" + Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db;Version=3;";
                // Veritabanı bağlantısını açın

                using (SQLiteConnection connection = new SQLiteConnection(connectionString)) // connectionString'i uygun şekilde ayarlayın
                {
                    connection.Open();

                    // Sorguyu çalıştırmak için SQLiteCommand kullanın
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserName", userName);
                        insertCommand.Parameters.AddWithValue("@Password", password);

                        // Sorguyu çalıştırın
                        insertCommand.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapatın
                    connection.Close();
                }

                // Kullanıcı ekledikten sonra işlemi tamamlayın (örneğin, bir mesaj göstererek veya formu kapatma gibi)
                MessageBox.Show("Kullanıcı başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.");
            }
        }

        private void UserDeleterBut_Click(object sender, EventArgs e)
        {


            string userNameToDelete = DelUserNameTextBox.Text.ToUpper(); // Sileceğiniz kullanıcının adını alın

            if (!string.IsNullOrEmpty(userNameToDelete))
            {
                // Kullanıcıyı silme işlemi için sorguyu oluşturun
                string deleteQuery = "DELETE FROM Users WHERE NickName = @UserNameToDelete";
                string connectionString = "Data Source=" + Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db;Version=3;";
                // Veritabanı bağlantısını açın
                using (SQLiteConnection connection = new SQLiteConnection(connectionString)) // connectionString'i uygun şekilde ayarlayın
                {
                    connection.Open();

                    // Sorguyu çalıştırmak için SQLiteCommand kullanın
                    using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@UserNameToDelete", userNameToDelete);

                        // Sorguyu çalıştırın
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen kullanıcı adıyla eşleşen bir kullanıcı bulunamadı.");
                        }
                    }

                    // Veritabanı bağlantısını kapatın
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
            }



        }
    }
}
