using System;

namespace ARRAY_SINIFI_METODLAR
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayiDizisi = { 22, 55, 323, 654, 658, 4321, 8, 432, 67, 97, 654 };
            Console.WriteLine("*************Sırasız Dizi************");
            foreach (var sayilar in sayiDizisi)
            {
                Console.WriteLine(sayilar);
            }
            // sort()
            Console.WriteLine("*************Sıralı Dizi************");
            Array.Sort(sayiDizisi);  // Büyükten kücüğe sıralar
            foreach (var sayilar in sayiDizisi)
            {
                Console.WriteLine(sayilar);
            }
            // Clear()
            Console.WriteLine("*************ARRAY CLEAR************");
            Array.Clear(sayiDizisi,5,5); // 5. indexten başlayarak 5 indexi sıfırladı.
            foreach (var sayilar in sayiDizisi)
            {
                Console.WriteLine(sayilar);
            }

            // Reverse()
            Console.WriteLine("*************ARRAY REVERSE************");
            Array.Reverse(sayiDizisi);  // 1.dizi elemanı ile son dizi elemanını 2. dizi ile sondan bir önceki elemanı şeklinde yer değiştirir.
            foreach (var sayilar in sayiDizisi)
            {
                Console.WriteLine(sayilar);
            }

            // İndexOf()
            Console.WriteLine("*************ARRAY iNDEXOF************");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 97)); // Girilen dizi değerinin kaçıncı dizi elemanı olduğunu söyler.

            // Resize()
            Console.WriteLine("*************ARRAY Resize************");
            Array.Resize<int>(ref sayiDizisi, 15);
            sayiDizisi[11] = 99;
            sayiDizisi[12] = 423;
            foreach (var sayilar in sayiDizisi)
            {
                Console.WriteLine(sayilar);
            }

        }
    }
}
