using System.Collections;
using System.Collections.Generic;

ArrayList asalSayi = new ArrayList();
ArrayList asalOlmayanSayi = new  ArrayList();

uint num, asalOrt = 0, asalOlmayanOrt = 0;
int say = 0;

// Asal sayı kontrolü için metod
static bool asalMi(uint sayi)
{
    for(var i = 2; i < sayi; i++)
    {
        if(sayi % i == 0)
        {
            return true;
        }
    }
    return false;
}

//Kullanıcıdan 20 adet değer alıp karakter kontolü ile birlikte asallar ve asal olmayan sayılar farklı 2 listeye eklendi.
while(say != 20)
{
    try
    {
        num = uint.Parse(Console.ReadLine());
        if(asalMi(num))
        {
            asalOlmayanOrt+=num;
            asalOlmayanSayi.Add(num);
        }    
            
        else
        {
            asalOrt+=num;
            asalSayi.Add(num);
        }
             
        say++;   
        
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen pozitif ve sayisal bir değer giriniz");
    }
    Console.WriteLine($"{say} adet sayı girdiniz {20-say} adet daha sayı girmelisiniz",say);

    
    
}
//Sort() metodu ile artan sırada yazdırıldı.
asalSayi.Sort();
asalOlmayanSayi.Sort();

// listenin elemanları ekrana yazdırıldı. 
foreach(var item in asalSayi)
{
    Console.WriteLine("Asal Sayilar : " + item);
    
}

foreach(var item in asalOlmayanSayi)
{
    Console.WriteLine("Asal olmayan Sayilar : " + item);
    
}

// Count ile listedeki eleman sayısı bulundu.
var asalElemanAdet = asalSayi.Count;
var asalOlmayanElemanAdet = asalOlmayanSayi.Count;

Console.WriteLine("Asal Eleman Sayısı : " + asalElemanAdet);
Console.WriteLine("Asal olmayan Eleman Sayısı : " + asalOlmayanElemanAdet);

//Ortalamaları alındı.
Console.WriteLine("Asal Sayıların Ortalaması : " + asalOrt/asalElemanAdet);
Console.WriteLine("Asal Olmayan Sayıların Ortalaması : " + asalOlmayanOrt/asalOlmayanElemanAdet);


