using System;

namespace METODLAR_OVERLOADİNG
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "4444";
            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.Write("Başarılı  ");
                Console.WriteLine(outSayi);

            }
            else
            {
                Console.WriteLine("Başarısız");

            }
            Metodlar metod = new Metodlar();
            metod.Topla(5, 99, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            // Metod Overloading -- Aşırı Yükleme

            int ifade = 444;
            metod.ekranaYazdır(Convert.ToString(ifade));
            metod.ekranaYazdır2("Mehmet ", "Doğanay");


        }
    }
    class Metodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;

        }
        public void ekranaYazdır(string yazdir)
        {
            Console.WriteLine(yazdir);
        }

        public void ekranaYazdır(int yazdir)
        {
            Console.WriteLine(yazdir);
        }

        public void ekranaYazdır2(string veri1 , string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}

