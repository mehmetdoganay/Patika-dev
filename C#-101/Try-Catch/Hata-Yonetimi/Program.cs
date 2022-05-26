using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try  // Kodun denetlendiği alan.Hata varmı yokmu kontrol sağlar
            {
                Console.WriteLine("Bir Sayı giriniz");
                int sayı = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Giriğiniz Sayı :" + sayı);
            }
            catch (Exception ex )  // Hata varsa eğer burada olası hata ile ilgili bilgi verilir. Ve programın Sağlıklı çalışmasını sağlar
            {
                Console.WriteLine("Hata :" + ex.Message.ToString());
                
            }
            finally   // İşlem hata döndürsede döndürmesede çalışan alan. Burası Opsiyoneldir.
            {
                Console.WriteLine("İşlem Gerçekleştirildi");
            }

            Console.WriteLine("*********** 2. ÖRNEK***********");
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("Test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex )
            {
                Console.WriteLine("Boş bir değer girilemez \n" + ex);
            }
            
            catch (FormatException ex )
            {
                Console.WriteLine(" Değişken Formatı Doğru değil \n" + ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok büyük veya Çok küçük bir değer girdiniz. \n" + ex);
            }
            
        }
    }
}
