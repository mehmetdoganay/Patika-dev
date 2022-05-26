using System.Collections;

List<char> sesliHarf = new List<char>(); // char türünde liste oluşturuldu

Console.Write("Herhangi bir cümle girebilirsiniz : ");
try
{
    string cumle = Console.ReadLine(); // string türünde bir girdi alındı
    char[] sesli = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'}; //char türünde sesli harflerin olduğu bir dizi oluşturuldu

    foreach (var harf in cumle) //cumledeki harfler döngüye alındı.
    foreach (var deger in sesli) //dizideki sesli harfler döngüye alındı.
    if(harf == deger) //Eğer Harf değere eşitse 
    {
        sesliHarf.Add(deger); //değeri listeye ekle
    }

    Console.BackgroundColor = ConsoleColor.DarkRed;
    for (int i = 0; i < sesliHarf.Count; i++) // Diziye eklediğimiz sesli harfleri yazdırıldı.
    {
        Console.WriteLine("Cümledeki sesli harfler : " + sesliHarf[i]); 
    }
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Dizideki sesli harf sayısı : " + sesliHarf.Count);
}
catch (System.Exception)
{
    throw;
}








