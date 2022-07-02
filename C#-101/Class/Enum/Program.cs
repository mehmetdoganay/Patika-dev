Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cuma);
Console.WriteLine((int)Gunler.Cumartesi);

int sicaklik = 26;

if (sicaklik > (int)HavaDurumu.Sicak)
    Console.WriteLine("Hava Dışarı Çıkmak için sıcak.");
else if (sicaklik > (int)HavaDurumu.Soguk)
    Console.WriteLine("Hava Dışarı Çıkmak için uygun.");
else
    Console.WriteLine("Hava Dışarı Çıkmak için uygun değil.");


enum Gunler
{
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 30,
    Cumartesi,
    Pazar,
}

enum HavaDurumu
{
    Soguk = 5,
    Normal =20,
    Sicak = 25,
    CokSicak= 35,
}