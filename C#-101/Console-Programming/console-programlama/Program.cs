using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("İsminiz :");
            string name = Console.ReadLine();
            Console.Write("Soyisminiz :");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
