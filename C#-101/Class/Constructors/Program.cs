
Calisan personel1 = new Calisan();

personel1.setPersonelBilgileri("Mehmet","Doğanay","Bilgi İslem",5000);

Calisan personel2 = new Calisan();

personel2.setPersonelBilgileri("Burak","Doğanay","İnsan Kaynakları",2600);

Calisan personel3 = new Calisan();

personel3.setPersonelBilgileri("Ayşe","Doğanay","Validasyon",7000);

Calisan personel4 = new Calisan();

personel4.setPersonelBilgileri("Rick","Shancez","ARGE",6500);

Calisan personel5 = new Calisan();

personel5.setPersonelBilgileri("Morty","Shancez","Stajyer",2000);


class Calisan
{
    public string Ad, Soyad, Kidem, Departman;
    public double Maas;
    public int IzinGunu;

    public Calisan(string ad, string soyad, string departman) {
        this.Ad = ad;
        this.Soyad = soyad;
        this.Departman = departman;
    }
     public Calisan(string ad, string soyad) {
        this.Ad = ad;
        this.Soyad = soyad;
    }
   
    public Calisan() {}

    public void setPersonelBilgileri(string Ad, string Soyad, string Departman, double Maas) {

        if(Ad.Length > 0 && Soyad.Length > 0 && Departman.Length > 0 ){
            if(Maas >= 2500)
            {
                this.Ad = Ad;
                this.Soyad = Soyad;
                this.Departman = Departman;
                this.Maas = Maas;
                this.Kidem = Kidem;
                this.IzinGunu = 14;

                if(Maas > 3000 & Maas < 4500)
                {
                    this.Kidem = "Kıdemli Personel";
                    this.IzinGunu = 20;
                }

                if(Maas > 4500 & Maas < 6000)
                {
                    this.Kidem = "Kıdemli Personel";
                    this.IzinGunu = 25;
                }

                if(Maas > 6000)
                {
                    this.Kidem = "Uzman Personel";
                    this.IzinGunu = 30;
                }
            }
        }

        Console.WriteLine("************************Yeni Personel***************************");
        Console.WriteLine("Personelin adı : " + Ad);
        Console.WriteLine("Personelin Soyadı : " + Soyad);
        Console.WriteLine("Personelin Departmanı : " + Departman);
        Console.WriteLine("Personelin Maaşı : " + Maas);
        Console.WriteLine("Personelin Kıdemi : " + Kidem);
        Console.WriteLine("Personelin İzin günü : " + IzinGunu);
    }
}
