using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // ATAMA VE İŞLEMLİ ATAMA
            int x = 55;
            int y = 32;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);
            Console.WriteLine("");
            // MATIKSAL OPERATORLER 
            //  || , && ,! 

            bool isSuccess = true;
            bool isComplate = false;

            if (isSuccess && isComplate)
                Console.WriteLine("Perfect");

            if (isSuccess || isComplate)
                Console.WriteLine("Great!");

            if (isSuccess && !isComplate)
                Console.WriteLine("Fine");
            Console.WriteLine("");
            //  İLİŞKİSEL OPERATORLER
            // < ,> =< ,=> , == ,!=

            int a = 5;
            int b = 70;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            Console.WriteLine("");

            // ARİTMETİK OPERATORLER
            // + ,- ,*,/ ,%

            int sayi = 55;
            int sayi2 = 5;
            int sonuc1 = sayi + sayi2;
            Console.WriteLine("Toplama:"+" "+sonuc1);
            int sonuc2 = sayi - sayi2;
            Console.WriteLine("Çıkarma:"+ " "+sonuc2);
            int sonuc3 = sayi * sayi2;
            Console.WriteLine("Çarpma:"+" " +sonuc3);
            int sonuc4 = sayi /sayi2;
            Console.WriteLine("Bölme:"+" "+sonuc4);
            int sonuc5 = sayi % sayi2;
            Console.WriteLine("Mod alma:"+" "+sonuc5);

            // Atama ve İşlemli Atama Operatörleri(=, +=, -=, *=, /=)    
            // Mantıksal Operatörler(||, &&, !)
            //  İlişkisel Operatörler(==,!=, <, >, >=,<=)
            //Aritmetik(+, -, *, /, %, ++, --)


        }
    }
}
