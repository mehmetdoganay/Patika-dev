using System;

namespace DİZİLER
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlaması
            string[] renkler = new string[5];

            string[] hayvanlar = { "kedi", "köpek","Maymun","Ejderha","Dinazor"};

            int[] dizi;
            dizi = new int[15];

            // değer atama ve erişim 
            renkler[0] = "mavi";  // yukarıda tanımladığım renkler dizisinin sıfırıncı elemanına atama yapıldı
            Console.WriteLine(hayvanlar[2]); // Hayvanlar dizisinin 3. lemanını consola yazdırıldı
            dizi[5] = 155; // dizi adındaki dizinin6. elemanına 155 değeri atandı.

            Console.WriteLine(dizi[5]);
            Console.WriteLine(renkler[0]);

            //Döngülerle Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamasını alan program
            Console.Write("Lütfen dizi eleman sayısını belirleyiniz: ");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];
            Console.WriteLine("Lütfen " + diziUzunlugu + " kadar sayı girişi yapınız.");
            int toplam = 0;
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Dizinin {0}. degerini giriniz: ",i+1);
                sayıDizisi[i]= Convert.ToInt32(Console.ReadLine()) ;
                toplam += sayıDizisi[i];

            }
            Console.WriteLine("Elamanların Ortalaması: " + toplam / (diziUzunlugu));
        }
    }
}
