using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
fruits.Add("Cherry");
fruits.Add("Pineapple");
fruits.Add("Litter");
fruits.Add("Peach");
fruits.Add("Blueberry");
fruits.Add("Coconut");
fruits.Add("Banana");

foreach (var fruit in fruits.Where(x => x == "Cherry"))
    Console.WriteLine(fruit);