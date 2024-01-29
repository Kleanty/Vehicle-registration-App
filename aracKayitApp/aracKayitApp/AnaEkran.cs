using System;
using System.Data;
using ClosedXML.Excel;//nuget paketi indiriyoruz kullanmak i�in
using System.Data.SQLite; // SQLite i�in gerekli using ifadesi
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using System.Xml;
//NuGet Konsolu a��ld���nda, "Browse" sekmesine ge�in ve arama kutusuna "System.Data.SQLite" yaz�n. Sonu�lar aras�ndan System.Data.SQLite paketini bulun.
//System.Data.SQLite paketini bulduktan sonra, paketin yan�ndaki "Install" d��mesine t�klayarak paketi projenize ekleyin. Bu i�lem, paketi projenize otomatik olarak indirip ekler.


namespace aracKayitApp
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void Kay�t_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db;Version=3;";
            Console.WriteLine(connectionString);
            SQLiteConnection connection = new(connectionString);
            connection.Open();

            string queryText = "SELECT CustomerNumber FROM Customers ORDER BY CustomerNumber DESC LIMIT 1";
            SQLiteCommand queryCommand = new SQLiteCommand(queryText, connection);
            int customerNumberSon = Convert.ToInt32(queryCommand.ExecuteScalar());//data basededn son customernumber� ald�k 

            string insertQuery = "INSERT INTO Customers (Name, TelNo, Plaka, Models,Tarih_ve_Zaman, Ariza, CustomerNumber)" +
            " VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6,@Value7)";

            DateTime kayitZamani = DateTime.Now;//verileri kay�t etmeden �nce tarih ve saati al�yoruz
            string tarihSaatMetni = kayitZamani.ToString("yyyy-MM-dd HH:mm:ss");

            SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Value1", nameText.Text.ToUpper()); // Name i�in bir de�er
            command.Parameters.AddWithValue("@Value2", telTex.Text); // TelNo i�in bir de�er
            command.Parameters.AddWithValue("@Value3", plakaText.Text.ToUpper()); // Plaka i�in bir de�er
            command.Parameters.AddWithValue("@Value4", modelText.Text); // Models i�in bir de�er
            command.Parameters.AddWithValue("@Value5", tarihSaatMetni); // Ariza i�in bir de�er
            command.Parameters.AddWithValue("@Value6", arizaText.Text); // Ariza i�in bir de�er
            command.Parameters.AddWithValue("@Value7", (customerNumberSon + 1)); // CustomerNumber i�in bir de�er
            kodLabel.Text = (customerNumberSon + 1).ToString();
            command.ExecuteNonQuery();
            connection.Close();
            //kaydet butonuna bas�ld�ktan sonra metinleri temizler ekrandan kullun�c� i�in i�lem h�zland�rma
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

            // Verileri Excel dosyas�na aktar�n.
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Veriler");

                // DataTable'dan verileri �ekerek Excel sayfas�na ekleyin.
                worksheet.Cell(1, 1).InsertTable(dataTable);

                // Excel dosyas�n� kaydedin.
                workbook.SaveAs(Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DataBase.xlsx");

                exelLabel.Text = string.Format(Functions.GetFolderPath() + "\\AracKayitApp" + " kals�r�nde olu�turuldu");
            }
        }

        private void AraBut_Click(object sender, EventArgs e)
        {
            string arananVeri = aramaTextBox.Text.ToUpper(); // Arad���n�z veriyi aramaTextBox'tan al�n
            string connectionString = "Data Source=" + Functions.GetFolderPath() + "\\AracKayitApp\\AracKayitApp_DB.db;Version=3;";

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            // Arama sorgusu
            string queryText = "SELECT * FROM Customers WHERE Name LIKE @ArananVeri OR Plaka LIKE @ArananVeri OR CustomerNumber LIKE @ArananVeri";
            SQLiteCommand queryCommand = new SQLiteCommand(queryText, connection);
            queryCommand.Parameters.AddWithValue("@ArananVeri", "%" + arananVeri + "%"); // "%" karakterleri verinin her iki yan�nda da olabilir, yani k�smi e�le�me yapar

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(queryCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bulunan verileri RichTextBox kontrol�ne yazd�r�n
            richTextBox1.Clear(); // �nceki i�eri�i temizle

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