using System;
using System.Data;
using ClosedXML.Excel;//nuget paketi indiriyoruz kullanmak için
using System.Data.SQLite; // SQLite için gerekli using ifadesi
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using System.Xml;
//NuGet Konsolu açýldýðýnda, "Browse" sekmesine geçin ve arama kutusuna "System.Data.SQLite" yazýn. Sonuçlar arasýndan System.Data.SQLite paketini bulun.
//System.Data.SQLite paketini bulduktan sonra, paketin yanýndaki "Install" düðmesine týklayarak paketi projenize ekleyin. Bu iþlem, paketi projenize otomatik olarak indirip ekler.


namespace aracKayitApp
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void Kayýt_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db;Version=3;";
            Console.WriteLine(connectionString);
            SQLiteConnection connection = new(connectionString);
            connection.Open();

            string queryText = "SELECT CustomerNumber FROM Customers ORDER BY CustomerNumber DESC LIMIT 1";
            SQLiteCommand queryCommand = new SQLiteCommand(queryText, connection);
            int customerNumberSon = Convert.ToInt32(queryCommand.ExecuteScalar());//data basededn son customernumberý aldýk 

            string insertQuery = "INSERT INTO Customers (Name, TelNo, Plaka, Models,Tarih_ve_Zaman, Ariza, CustomerNumber)" +
            " VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6,@Value7)";

            DateTime kayitZamani = DateTime.Now;//verileri kayýt etmeden önce tarih ve saati alýyoruz
            string tarihSaatMetni = kayitZamani.ToString("yyyy-MM-dd HH:mm:ss");

            SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Value1", nameText.Text.ToUpper()); // Name için bir deðer
            command.Parameters.AddWithValue("@Value2", telTex.Text); // TelNo için bir deðer
            command.Parameters.AddWithValue("@Value3", plakaText.Text.ToUpper()); // Plaka için bir deðer
            command.Parameters.AddWithValue("@Value4", modelText.Text); // Models için bir deðer
            command.Parameters.AddWithValue("@Value5", tarihSaatMetni); // Ariza için bir deðer
            command.Parameters.AddWithValue("@Value6", arizaText.Text); // Ariza için bir deðer
            command.Parameters.AddWithValue("@Value7", (customerNumberSon + 1)); // CustomerNumber için bir deðer
            kodLabel.Text = (customerNumberSon + 1).ToString();
            command.ExecuteNonQuery();
            connection.Close();
            //kaydet butonuna basýldýktan sonra metinleri temizler ekrandan kullunýcý için iþlem hýzlandýrma
            Functions.ClearTextBoxes(this);
            Functions.ClearRichTextBoxes(this);

        }

        private void ExeleAktarBut_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db;Version=3;";
            Console.WriteLine(connectionString);
            SQLiteConnection connection = new(connectionString);
            connection.Open();

            string yourQuery = "SELECT * FROM Customers";

            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(yourQuery, connection);
            adapter.Fill(dataTable);

            // Verileri Excel dosyasýna aktarýn.
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Veriler");

                // DataTable'dan verileri çekerek Excel sayfasýna ekleyin.
                worksheet.Cell(1, 1).InsertTable(dataTable);

                // Excel dosyasýný kaydedin.
                workbook.SaveAs(Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DataBase.xlsx");

                exelLabel.Text = string.Format(Functions.GetFolderPath() + "\\AracKayitApp" + " kalsöründe oluþturuldu");
            }
        }

        private void AraBut_Click(object sender, EventArgs e)
        {
            string arananVeri = aramaTextBox.Text.ToUpper(); // Aradýðýnýz veriyi aramaTextBox'tan alýn
            string connectionString = "Data Source=" + Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db;Version=3;";

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            // Arama sorgusu
            string queryText = "SELECT * FROM Customers WHERE Name LIKE @ArananVeri OR Plaka LIKE @ArananVeri OR CustomerNumber LIKE @ArananVeri";
            SQLiteCommand queryCommand = new SQLiteCommand(queryText, connection);
            queryCommand.Parameters.AddWithValue("@ArananVeri", "%" + arananVeri + "%"); // "%" karakterleri verinin her iki yanýnda da olabilir, yani kýsmi eþleþme yapar

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(queryCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bulunan verileri RichTextBox kontrolüne yazdýrýn
            richTextBox1.Clear(); // Önceki içeriði temizle

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    richTextBox1.AppendText(col.ColumnName + ": " + row[col].ToString() + "\n");
                }
                richTextBox1.AppendText("\n");
            }

            connection.Close();
        }

        private void SafeExit_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Hide();
            loginScreen.Show();
        }
    }
}