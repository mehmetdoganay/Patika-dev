using System;

namespace DONGULER_FOR_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayıya kadar olan tek sayıların  ekrana yazımı 
            try
            {
                Console.Write("Bir Sayı Giriniz :");
                int sayac = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < sayac; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 1 ile 1000 arasındaki tek sayılar ve çift sayıları toplayalım
           
            int ciftler = 0;
            int tekler = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekler += i;
                }
                else
                {
                    ciftler += i;
                }


            }
            Console.WriteLine("Toplam tek sayılar : " + tekler);
            Console.WriteLine("Toplam çift sayılar : " + ciftler);

            // break continue
            for (int i = 0; i < 10; i++)
            {
                if(i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                   continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
