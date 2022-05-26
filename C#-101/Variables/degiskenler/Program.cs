using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değikenler");

            byte b = 5;      // 0-255
            sbyte v = 5;     // -128 , 127

            short s = 4;     // 2 byte
            ushort t = 1;    // 2 byte

            Int16 i = 2;     // 2 byte   
            int x = 4;       // 4 byte   
            Int32 w = 32;    // 4 byte
            Int64 y = 64;    // 8 byte
            uint ui = 2;     // 4 byte

            float f = 4;     // 4 byte
            double d = 8;    // 8 byte
            decimal r = 16;  // 16 byte

            char ch = '2';    // 1 byte 1 karakter
            string str = "Sınırsız";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "sting değer";
            object o2 = 'c';    // char deger
            object o3 = 1000;   //integer deger
            object o4 = 4.2;

            // STRİNG İFADELER 

            string str1 = string.Empty;
            str1 = "Mehmet Doganay";
            string ad = "Mehmet";
            string soyad = "Doganay";
            string tamisim = ad +" "+ soyad;
            Console.WriteLine(tamisim);

            // integer tanımlama 

            int int1 = 333;
            int int2 = 3;
            int carp = int1 * int2;
            Console.WriteLine(carp);

            //Boolean

            bool a1 = 10 < 4;
            Console.WriteLine(a1);

            // Değişken Dönüşümleri 
            string str10 = "20";
            int int10 =  3;

            string yenideger = str10 + int10.ToString(); // stringe dönüştürdük
            Console.WriteLine(yenideger);

            int intdonusum = int10 + Convert.ToInt32(str10);
            Console.WriteLine(intdonusum); // çıktı 23

            int int40 = int10 + int.Parse(str10);
            Console.WriteLine(int40);

            // datetime 

            string dateTime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(dateTime);

            string dateTime1 = DateTime.Now.ToString("dd/mm/yyyy");
            Console.WriteLine(dateTime1);

            string dateTime2 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dateTime2);


        }
    }
}
