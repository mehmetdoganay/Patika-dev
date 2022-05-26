using System;

namespace AlgoritmaSorusu2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


            Console.WriteLine("LÜtfen 2 Adet sayı değeri giriniz");
            Console.Write("Birinci değeri giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci değeri giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}. Sayı değerini giriniz: ", i + 1);
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                    if (sayilar[i] <0)
                    {
                        Console.WriteLine("Pozitif olmayan değerler girilemez.");
                        break;
                    }
                }

                Console.WriteLine("**************Sonuçlar***********");
                foreach (var sayi in sayilar)
                {
                    if (sayi == m || sayi % m == 0)
                    {
                        Console.WriteLine("{0} Koşullara uygun bir değer.", sayi);
                    }
                    else
                    {
                        Console.WriteLine("Malesef {0} Koşullara uygun bir değer değil.", sayi);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata" + ex.Message.ToString());
            }
            
            
        }
    }
}
