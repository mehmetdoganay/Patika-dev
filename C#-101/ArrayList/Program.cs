using System.Collections;
using System.Collections.Generic;

// ArrayList 
// Bu dizide tüm değişken türlerini tanımlayabilirsiniz.
ArrayList liste = new ArrayList();
liste.Add("Mehmet");
liste.Add(22);
liste.Add(true);
liste.Add('E');

// Verilere erişmek
foreach(var özellik in liste)
{
    Console.WriteLine(özellik);
}

// AddRange Toplu Eleman ekleme
Console.WriteLine("****************AddRange()***************");
string[] renkler = {"kırmızı", "sarı", "mor"};
int[] sayılar = {5,3,7,9,5,8,77,35,43554,};

liste.AddRange(renkler);
liste.AddRange(sayılar);

List<int> num = new List<int>{3312,312,342,65,876,456};

liste.AddRange(num);

foreach(var özellik in liste)
{
    Console.WriteLine(özellik);
}

// Sort Listeyi sıralamak
Console.WriteLine("******Sort() Hata !! *******");
//liste.Sort(); // HATA

//Sort() metodu küçükten büyüğe sıralama yapar fakat arraylist içerisinde sıralanacak olan değerler biririnden farklı veri tipleri içeriyorsa bu diziyi bir sıralamaya sokamaz hata verir.

ArrayList numbers = new ArrayList();
List<int> say = new List<int>(){9,6,5,4,7,0,3,2,1};
numbers.AddRange(say);

// Sort()
Console.WriteLine("******Sort()*******");
numbers.Sort();
foreach(var item in numbers)
{  
    Console.WriteLine(item);
}

// BinarySearch() 
Console.WriteLine("******BinarySearch()*******");
Console.WriteLine(numbers.BinarySearch(4)); // 2. indeksteki sayıyı getirir.

// Reverse
Console.WriteLine("******Reverse()*******");
numbers.Reverse();
foreach(var item in numbers)
{  
    Console.WriteLine(item);
}

// Clear Listeyi Temizler
numbers.Clear();
foreach(var item in numbers)
{  
    Console.WriteLine(item);
}

