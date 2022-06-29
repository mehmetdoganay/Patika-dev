Calisan personel1 = new Calisan("Mehmet","Doğanay","Bilgi İşlem");
Calisan personel2 = new Calisan("Ayse", "Doğanay", "Bilgi İşlem");

Console.WriteLine("Calışan Sayısı : {0} ", Calisan.CalisanSayisi);

Console.WriteLine(Islemler.Topla(4, 6));

class Calisan
{   
    private static int calisanSayisi;
    private string Isim;
    private string Soyisim;
    private string Departman;

    public static int CalisanSayisi { get => calisanSayisi; }


    // static kurucuların erişim belirteci olmaz
    static Calisan()
    {
        calisanSayisi = 0;

    }
    
    public Calisan(string isim, string soyisim, string departman)
    {
        Isim = isim;
        Soyisim = soyisim;
        Departman = departman;
        calisanSayisi ++;
    }
}

static class Islemler
{
    public static long Topla(int num1, int num2)
    {
        return num1 + num2;
    }


    public static long Cikar(int num1, int num2)
    {
        return num1 - num2;
    }
}