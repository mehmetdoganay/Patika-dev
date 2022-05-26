using System;

namespace DONGULER_WHİLE_FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1 den başlayarak consoldan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp kosola yazdıran program. 
            Console.Write("Sayı giriniz: ");
            int sayı = int.Parse(Console.ReadLine());
            int sayaç = 0;
            int toplam = 0;
            while (sayı >=sayaç) 
            {
                sayaç++;
                toplam += sayaç;
            }
            Console.WriteLine("Sonuç: "+toplam/sayı );

            // a dan z ye kadar tüm harfleri yazdıralım
            char chr = 'a';
            while (chr < 'z')
            {
                Console.Write(chr);
                chr++;
            }

            Console.WriteLine("*******FOREACH********");
            string[] arabalar = { "MERCEDES", "FORD", "FİAT", "BMW" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
