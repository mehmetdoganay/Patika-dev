using System;

namespace AlgoritmaSorusu3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Lütfen kelime sayısını giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.Kelimeyi giriniz: ",i+1);
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);
            Console.WriteLine("***************SONUÇLAR*************");
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

        }
    }
}
