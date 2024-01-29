using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace aracKayitApp
{
    internal class Functions
    {
        public static String GetFolderPath()
        {
            string belgelerKlasoruYolu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(belgelerKlasoruYolu);
            return belgelerKlasoruYolu;
        }

        public static bool CreateFolder(string rootPath, string folderName)
        {
            try
            {
                string folderPath = Path.Combine(rootPath, folderName);

                if (!Directory.Exists(folderPath))
                {
                    // Klasör zaten mevcut değilse oluştur
                    Directory.CreateDirectory(folderPath);
                }

                // Klasör başarıyla oluşturuldu veya zaten mevcutsa true döndür
                return true;
            }
            catch (Exception ex)
            {
                // Hata oluştuğunda hata mesajını yazdır
                Console.Error.WriteLine("Klasör oluşturulamadı: " + folderName);
                Console.Error.WriteLine(ex.Message);

                // Klasör oluşturulamadığında veya zaten mevcutsa false döndür
                return false;
            }
        }

        public static bool TxtCreator(string DosyaYolu)
        {
            try
            {
                // StreamWriter kullanarak dosyayı oluşturuyoruz.
                using StreamWriter sw = new(DosyaYolu);

                return true; // Dosya oluşturulduğunda true döndürüyoruz.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
                return false; // Hata durumunda false döndürüyoruz.
            }
        }

        public static string? FileSelector()
        {
            using OpenFileDialog dialog = new();
            dialog.Title = "Dosya Seç";
            dialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*"; // Filtreleyebilirsiniz.
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // İlk açıldığında hangi dizinde başlayacağını ayarlayabilirsiniz.

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName; // Kullanıcı bir dosya seçtiyse dosyanın yolunu döndürür.
            }
            else
            {
                return null; // Kullanıcı dosya seçmediyse null döndürür.
            }

        }

        public static void ClearTextBoxes(Control control)// control wimndows formdaki  tüm alt ögeleri (child) kontrol etmek için kullanılır.
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearTextBoxes(c);
                }
            }

        }

        public static void ClearRichTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
                else
                {
                    ClearRichTextBoxes(c);
                }
            }
        }

    }
}
