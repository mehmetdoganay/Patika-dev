using System.Collections.Generic;
// Dictionary
// key and value !!
// System.Collection.Generic
// !!! Keyler uniq olmak zorunda

Dictionary<int, string> users = new Dictionary<int, string>();
users.Add(1,"Mehmet Doğanay");
users.Add(2,"Elifnur Akcur");
users.Add(3,"Ayşe Doğanay");
users.Add(4,"Burak Doğanay");

// Dizinin elemanlarına erişmek
Console.WriteLine("*******Elemanlara Erişmek******");
Console.WriteLine(users[1]);
foreach(var item in users)
{
    Console.WriteLine(item);
}

// Count()
Console.WriteLine("*******Count******");
Console.WriteLine(users.Count());

//Contains
// Varmı yokmu Sorgusunu sordurur ve True False döner

Console.WriteLine("*******Contains******");
Console.WriteLine(users.ContainsKey(2)); // anahtar değeri 2 olan bir değer varmı ?
Console.WriteLine(users.ContainsValue("Burak Doğanay")); // users dizisinde Değeri Burak Doğanay olan bir dizi varmı ?

// Remove

Console.WriteLine("*******Remove******");
users.Remove(3);
Console.WriteLine(users.ContainsKey(3));

//Keys
Console.WriteLine("*******Keys*******");
foreach(var item in users.Keys)
{
    Console.WriteLine(item);
}

//Values
Console.WriteLine("*******Values*******");
foreach(var item in users.Values)
{
    Console.WriteLine(item);
}