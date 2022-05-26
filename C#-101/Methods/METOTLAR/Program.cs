using System;

namespace METOTLAR
{
    class Program
    {

        static int f(int x)
        {
            return x + 5;
        }

        

        static void Main(string[] args)
        {
            // erişim belirteci geri-dönüş tipi metod adı(parametrelistesi/arguman)
            // {
            // komutlar
            //}
            //int sayı1 = 6;
            //int sayı2 = 4;
            //Console.WriteLine(sayı1 + sayı2);

            //int sonuc = topla(sayı1, sayı2);
            //Console.WriteLine(sonuc);

            //metotlar ornek = new metotlar();
            //ornek.EkranaYazdır(Convert.ToString(sonuc));

            //int sonuc2 = ornek.ArttirVeTopla(ref sayı1,ref sayı2);
            //ornek.EkranaYazdır(Convert.ToString(sonuc2));

            // Random 
            Console.WriteLine(10 + f(6) + 1); // f fonksiyonunu yazdırdık
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                Console.Write("Yazı mı Tura mı ? Yazı ise 1 Tura ise 2  ");
                int deger = Convert.ToInt32(Console.ReadLine());

                int sayi = random.Next(1, 3);
                Console.WriteLine("Random Sayı : " + sayi + " Girilen Değer : " + deger);
                if (deger == sayi)
                {
                    if (deger == 1)
                    {
                        Console.WriteLine("Yazı");
                    }
                    else
                    {
                        Console.WriteLine("Tura");
                    }
                }
                else
                {
                    Console.WriteLine("Bugün şenslı günün değil galiba. Tekrar dene.\n");
                }
            }
            
        }
        static int topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }


    }
    class metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine("EkranaYazdır metoduna ait çıktı " + veri);
        }
        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
    }
}
