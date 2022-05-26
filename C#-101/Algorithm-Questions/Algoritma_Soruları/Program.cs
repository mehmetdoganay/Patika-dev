using System;
using System.Collections.Generic;

namespace Algoritma_Soruları
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            try
            {
                Console.Write("Lütfen sayı adedini belirleyiniz : ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] sayilar = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Lütfen {0}. sayı değerini giriniz :", i + 1);
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                    if (sayilar[i] < 0)
                    {
                        Console.WriteLine("Lütfen pozitif tam sayı değerler giriniz.");
                        break;
                    }
                }

                Console.WriteLine("**************Sonuçlar***********");

                foreach (var sayi in sayilar)
                {
                    if (sayi % 2 == 0)
                    {


                        Console.WriteLine("{0} Bir Çift Sayıdır", sayi);


                    }
                    else
                    {
                        Console.WriteLine("{0} Bir Tek Sayıdır", sayi);
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
