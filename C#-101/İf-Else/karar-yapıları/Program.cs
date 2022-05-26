using System;

namespace karar_yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time <= 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }

            string sonuc = time <= 18 ? "İyi günler":"İyi Geceler";
            sonuc = time >= 6 && time <= 11 ? "Günaydın":"İyi Akşamlar";
            Console.WriteLine(sonuc);
        }
    }
}
