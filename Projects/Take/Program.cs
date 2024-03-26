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

foreach (var fruit1 in fruits.Take(3))
    Console.WriteLine(fruit1);
foreach (var fruit2 in fruits.Take(..3))    
    Console.WriteLine(fruit2);
foreach (var fruit3 in fruits.Take(1..3))    
    Console.WriteLine(fruit3);