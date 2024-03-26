using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
fruits.Add("Cereja");
fruits.Add("Cereja");
fruits.Add("Cereja");
fruits.Add("Cereja");
fruits.Add("Cereja");
fruits.Add("Cereja");

Console.WriteLine(fruits.All(x => x == "Cereja"));
//Console.WriteLine(fruits.All(x => x.Idade > 18));
