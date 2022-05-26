using System.Collections;

List<int> Sayilar = new List<int>();
int sayi, say = 0;

Console.Write("Lütfen 20 adet sayı giriniz.");
while(say != 20)
{
// Kullanıcıdan 20 adet integer değer alındı.
    try
    {
        for(var i = 0; i < 20; i++)
        {
            sayi = int.Parse(Console.ReadLine());
            Sayilar.Add(sayi);
            say++;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen sayısal bir değer giriniz !");
    }
}

//Sort metodu ile Listedeki elemanları küçükten büyüğe sıralandı
var kucukTopla = 0;
Sayilar.Sort();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Dizideki en küçük 3 sayı : {Sayilar[0]} - {Sayilar[1]} - {Sayilar[2]}");

int[] kucukSayilar = Sayilar.ToArray(); //ToArray Metodu ile Sayilar Listesi int bir diziye atıldı.

// Sort ile sıraladığımız Listeyi Reverse ile tersine çevirerek büyükten küçüğe sıralamış olduk.
int buyukTopla = 0;
Sayilar.Reverse();

Console.WriteLine($"Dizideki en büyük 3 sayı : {Sayilar[0]} - {Sayilar[1]} - {Sayilar[2]}");


int[] buyukSayilar = Sayilar.ToArray(); // //ToArray Metodu ile Sayilar Listesi int bir diziye atıldı.

for (int i = 0; i < 3; i++)
{
    buyukTopla += buyukSayilar[i];
}

for (int i = 0; i < 3; i++)
{
    kucukTopla += kucukSayilar[i];
}

int ortalamaToplam = (buyukTopla / 3) + (kucukTopla / 3);

Console.ForegroundColor = ConsoleColor.Red; 
Console.WriteLine("Dizideki en büyük 3 sayının ortalaması : " + buyukTopla / 3);
Console.WriteLine("Dizideki en küçük 3 sayının ortalaması : " + kucukTopla / 3);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Dizideki en küçük 3 ve en büyük 3 sayının ortalamalarının toplamları : " + ortalamaToplam);