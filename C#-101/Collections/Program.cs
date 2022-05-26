using System;
using System.Collections.Generic;

// List 
// List<T> class
// System.Collection.Generic
//T -> object Türündedir.
//T -> Listenin içerisindeki nesnelerin tipini ifade eder.
//Örnek

List<int> sayiListesi = new List<int>();

sayiListesi.Add(321);
sayiListesi.Add(12);
sayiListesi.Add(66);
sayiListesi.Add(9);
sayiListesi.Add(6);
sayiListesi.Add(144);
sayiListesi.Add(77);
sayiListesi.Add(78);

List<string> renkListesi = new List<string>();

renkListesi.Add("mavi");
renkListesi.Add("sarı");
renkListesi.Add("mor");
renkListesi.Add("siyah");
renkListesi.Add("turuncu");
renkListesi.Add("pembe");
renkListesi.Add("beyaz");
renkListesi.Add("yeşil");

// Count
Console.WriteLine(sayiListesi.Count);
Console.WriteLine(renkListesi.Count);

// foreach 
foreach (var item in renkListesi)
{
    Console.WriteLine(item);
}

foreach (var item in sayiListesi)
{
    Console.WriteLine(item);
}

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

// Listeden eleman çıkarma

sayiListesi.Remove(66);
renkListesi.Remove("siyah");

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

// Listeden indexe göre eleman çıkarma

sayiListesi.RemoveAt(3);
renkListesi.RemoveAt(4);

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

// Liste içerisinde arama

if(sayiListesi.Contains(6))
    Console.WriteLine("6 liste içerisinde bulunudu");
else
    Console.WriteLine("6 Liste içerisinde bulunamadı");

// Eleman içerisinde index'e erişmek

Console.WriteLine(renkListesi.BinarySearch("mavi"));

// Diziyi Listeye çevirmek

string[] hayvanlar = {"Dinazor","balık","kuş"};

List<string> hayvanList = new List<string>(hayvanlar);

//Listeyi Temizleme

hayvanList.Clear();

// List içerisinde nesne tutmak

List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

Kullanıcılar kullanıcı1 = new Kullanıcılar();
kullanıcı1.Isim = "Ayşe";
kullanıcı1.Soyisim = "Doğan";
kullanıcı1.Yaş = 44;

Kullanıcılar kullanıcı2 = new Kullanıcılar();
kullanıcı2.Isim = "mehmet";
kullanıcı2.Soyisim = "doğanay";
kullanıcı2.Yaş = 22;

kullanıcıListesi.Add(kullanıcı1);
kullanıcıListesi.Add(kullanıcı2);

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
yeniListe.Add(new Kullanıcılar(){
    Isim = "elif",
    Soyisim = "akcr",
    Yaş = 21
});

foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
{
    Console.WriteLine("Kullanıcı Ad :"+kullanıcı.Isim);
    Console.WriteLine("Kullanıcı Soyad :"+kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı Yaşı :"+kullanıcı.Yaş);
}



public class Kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yaş;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yaş { get => yaş; set => yaş = value; }
}