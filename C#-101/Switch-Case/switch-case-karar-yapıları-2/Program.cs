﻿using System;

namespace switch_case_karar_yapıları_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            // Experssion
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayı");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayı");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayı");
                    break;
                case 5:
                    Console.WriteLine("Mayıs Ayı");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayı");
                    break;
                    Console.WriteLine("Yanış Veri Girişi.");
                    break;
                default:
                    break;

            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimindesiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimindesiniz");
                    break;
                default:
                    break;


            }
        }
    }
}
