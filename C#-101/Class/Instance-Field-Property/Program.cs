
Calısan personel1 = new Calısan();

personel1.Ad = "Mehmet";
personel1.Soyad = "Doğanay";
personel1.No = 0001;
personel1.Departman = "Bilgi İşlem";

personel1.CalisanBilgiYazdir();

Calısan personel2 = new Calısan();

personel2.Ad = "Burak";
personel2.Soyad = "Doğanay";
personel2.No = 0002;
personel2.Departman = "İnsan Kaynakları";

personel2.CalisanBilgiYazdir();


class Calısan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgiYazdir()
    {
        Console.WriteLine("Personelin adı : " + Ad);
        Console.WriteLine("Personelin Soyadı : " + Soyad);
        Console.WriteLine("Personelin Numarası" + No);
        Console.WriteLine("Personelin Departmanı : " + Departman);
    }
}