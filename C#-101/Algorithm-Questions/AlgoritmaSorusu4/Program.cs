using System;

namespace AlgoritmaSorusu4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            Console.WriteLine("*****************DEĞERLER******************");

            Harf(cumle);
            Kelime(cumle);
        }

        public static void Harf(string x)
        {
            string birlestir = x.Trim().Replace(" ",string.Empty);
            Console.WriteLine("Harf sayısı: " + birlestir.Length);
        }
        public static void Kelime(string x)
        {
            string[] kelimeler = x.Split(" ");
            Console.WriteLine("Kelime sayısı: {0}",kelimeler.Length);

        }
    }
}
