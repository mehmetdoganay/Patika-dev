using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // rekürsif - öz yineleme
            // 3^4 = 3*3*3
            int result = 1;
            for (int i = 0; i < 4; i++)
            {
                result = result * 3;
                Console.WriteLine(result);
            }
            Islemler ıslemler = new Islemler();
            Console.WriteLine(ıslemler.Expo(3, 4));

            ////Extension Metodlar
            string ifade = "Mehmet doğanay";

            bool sonuc = ifade.checkSpace();
            Console.WriteLine(sonuc);
            if (sonuc)
                Console.WriteLine("RemoveWhiteSpaces : " + ifade.RemoveWhiteSpaces());
            Console.WriteLine("MakeUpperCase : " + ifade.MakeUpperCase());
            Console.WriteLine("MakeLowerCase : " + ifade.MakeLowerCase());

            int[] sayılar = { 4, 5, 6, 8, 3, 9, 0, 7 };
            sayılar.SortArray();
            sayılar.EkranaYazdır();
            

            int ciftmi = 3;
            Console.WriteLine(ciftmi.IsEvenNumber());

            Console.WriteLine(ifade.İlkKarakter());

            

        }
    }
    public class Islemler
    {
        public int Expo(int sayi1 , int us)
        {
            if (us < 2)
                return sayi1;
            return Expo(sayi1, us - 1)*sayi1;
        }
        // Expo(3,4)
        // Expo(3,3) * 3
        // Expo(3,2) * 3 * 3
        // Expo (3,1) * 3 * 3 * 3
        // 3 * 3 * 3 * 3 = 81
    }

    public static class Extension
    {
        public static bool checkSpace(this string para)
        {
            return para.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string para)
        {
            string[] dizi = para.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string para)
        {
            return para.ToUpper();
        }

        public static string MakeLowerCase(this string para)
        {
            return para.ToLower();
        }

        public static int[] SortArray(this int[] para)
        {
            Array.Sort(para);
            return para;
        }

        public static void EkranaYazdır(this int[]  para)
        {
            for (int i = 0; i < para.Length; i++)
            {
                Console.WriteLine(para[i]);
            }
        }

        public static bool IsEvenNumber(this int para)
        {
            
            return para % 2 == 0;
           
        }

        public static string İlkKarakter(this string para)
        {
           return para.Substring(0,1);
        }
    }
}
