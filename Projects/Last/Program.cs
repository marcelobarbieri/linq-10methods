using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
fruits.Add("Cherry");
fruits.Add("Cherry"); // This

fruits.Add("Pineapple");
fruits.Add("Litter");
fruits.Add("Peach");
fruits.Add("Blueberry");
fruits.Add("Coconut");
fruits.Add("Banana"); // This

Console.WriteLine(fruits.Last());
Console.WriteLine(fruits.Last(x => x == "Cherry"));