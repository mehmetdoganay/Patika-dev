using System;

namespace Hazır_Metodlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string değişken = "Bugün csharp dilinde hazır metodları öğreniyoruz.";
            string değişken2 = "bugün csharp dilinde hazır metodları öğreniyoruz.";
            string değişken3 = "csharp";
            string değişken4 = "Merhaba bugün csharp dilinde hazır metodları öğreniyoruz.";


            // Length;
            // Length ile değişkenin içinde kaç adet karakter var bunu bize verir. Boşluklarda dahil.
            Console.WriteLine("Length; " + değişken.Length);
            Console.WriteLine("Length; " + değişken2.Length);

            //ToUpper - ToLower 
            //Değişkendeki tüm karakterleri büyük harf ve küçük harf yapar.
            Console.WriteLine("ToUpper() " + değişken.ToUpper());
            Console.WriteLine("ToLower() " + değişken.ToLower());

            //Concact
            //Değişkene Ekleme yapar.
            Console.WriteLine("Concact() " + string.Concat(değişken, "Merhaba"));

            //Compare , CompareTo
            //CompareTo 2 değikeni karşılaştırır. 1.değişkeni ile 2 değişken eşit = 0 veya 1.değişken daha büyük = -1 veya daha küçük = 1 
            //
            Console.WriteLine("CompareTo()" + değişken.CompareTo(değişken2)); // 0,1,-1
            Console.WriteLine("Compare ,True" + string.Compare(değişken, değişken2, true)); // Sonradi true ile büyük küçük harf duyarlıdır false tam tersi.
            Console.WriteLine("Compare False" + string.Compare(değişken, değişken2, false));

            //Contains
            //Containsde değişken2'nin  içinde değişken3 var mı ?
            Console.WriteLine("Contains() " + değişken2.Contains(değişken3));

            //EndWith
            //Sonu belirttiğin değer ile bitiyormu ?
            Console.WriteLine("EndWith() " + değişken.EndsWith("Hoşgeldiğiniz"));

            //StartWith
            //Merhaba ile başlıyormu
            Console.WriteLine("StartWith() " + değişken4.StartsWith("Merhaba"));

            //IndexOf
            //Veridğin değerden önceki değerlerin karakter sayısını verir
            // Bulamazsa -1 döner.
            Console.WriteLine("IndexOf() " + değişken.IndexOf("csharp"));

            //Insert()
            // Ekelem yapar ile değer nereden başlayağını belirtir 2. değer ise ne ekelmek istediğini.
            Console.WriteLine("Insert() " + değişken.Insert(0, "Selam"));

            //LastIndexOF
            // Verdiğin string değerin değişkende en sondakini bulur ve kaçıncı sırada olduğunu söyler.
            Console.WriteLine("LastIndexOf() " + değişken.LastIndexOf("i"));

        }  
    }
}
