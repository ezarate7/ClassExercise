using System;
using System.Collections.Generic;
using classes;

var myCar = new car();
myCar.Make = "Toyota";
myCar.Model = "Rav4";
myCar.Year = 2021;
Console.WriteLine("What car do you have?");
Console.WriteLine();
Console.WriteLine($"Make: { myCar.Make}");
Console.WriteLine(  );
Console.WriteLine($"Model: {myCar.Model}");
Console.WriteLine();
Console.WriteLine($"Year: {myCar.Year}");
