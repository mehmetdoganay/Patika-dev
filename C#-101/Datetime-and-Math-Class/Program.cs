// DATETİME
Console.WriteLine("Full Date :" +DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);  

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());

Console.WriteLine(DateTime.Now.AddDays(7));
Console.WriteLine(DateTime.Now.AddMonths(2));
Console.WriteLine(DateTime.Now.AddYears(1));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddMonths(60));
Console.WriteLine(DateTime.Now.AddSeconds(3));

// DATETİME format

Console.WriteLine(DateTime.Now.ToString("dd")); 
Console.WriteLine(DateTime.Now.ToString("ddd")); 
Console.WriteLine(DateTime.Now.ToString("dddd")); 

Console.WriteLine(DateTime.Now.ToString("MM")); 
Console.WriteLine(DateTime.Now.ToString("MMM")); 
Console.WriteLine(DateTime.Now.ToString("MMMM")); 

Console.WriteLine(DateTime.Now.ToString("yy")); 
Console.WriteLine(DateTime.Now.ToString("yyyy"));  


// MATH 
Console.WriteLine("****************-MATH KÜTÜPHANESİ-****************");

Console.WriteLine(Math.Abs(-25)); // 25
Console.WriteLine(Math.Ceiling(22.1)); // 23
Console.WriteLine(Math.Round(24.2));  // 24
Console.WriteLine(Math.Round(24.7)); // 25
Console.WriteLine(Math.Floor(22.8)); // 22

Console.WriteLine(Math.Max(22,66)); // 66
Console.WriteLine(Math.Min(55,99));  // 55

Console.WriteLine(Math.Pow(2,5)); //2^5 = 32
Console.WriteLine(Math.Sqrt(9)); // 3