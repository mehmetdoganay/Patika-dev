using System;

namespace Tip_Donuşumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion  - Bilinçsiz Dönüşüm
            byte a = 4;
            sbyte b = 45;
            short c = 63;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float t = h;
            Console.WriteLine(h);

            string e = "Mehmet";
            char f = 'a';
            object g = e + f + d;
            Console.WriteLine(g);


            // Explicit Conversion - Bilinçli Dönüşüm

            Console.WriteLine("************Bilinçsiz Dönüşümler***********");
            int ı = 15;
            byte o = (byte)ı;
            Console.WriteLine(o);

            int p = 190;
            string j = p.ToString();
            Console.WriteLine(j);

            float q = 17.8f;
            byte w = (byte)q;
            Console.WriteLine(w);

            // ************ ToString Motodu **********
            Console.WriteLine("********ToString Metodu ***********");
            int int1 = 2000;
            string str1 = int1.ToString();
            Console.WriteLine(str1);

            string str2 = 15.76f.ToString();
            Console.WriteLine(str2);

            //************Convert Dönüşüm************
            Console.WriteLine("***********Convert Dönüşüm ************");
            string str4 = "14", str5 = "10";
            int int4, int5,toplam;
            int4 = Convert.ToInt32(str4);
            int5 = Convert.ToInt32(str5);
            toplam = int4 + int5;
            Console.WriteLine(toplam);

            // *********PARSE *************
            Console.WriteLine("***********PARSE METOD **************");
            ParseMedot();
        }

        public static void ParseMedot()
        {
            string a = "1000";
            string b = "100.55";
            int rakam;
            double double1 ;

            rakam = Int32.Parse(a);
            Console.WriteLine(rakam);

            double1 = double.Parse(b);
            Console.WriteLine(double1);
        }
    }
}
