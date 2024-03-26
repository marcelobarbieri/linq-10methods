using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
fruits.Add("Cherry");
fruits.Add("Cherry");
fruits.Add("Cherry");
fruits.Add("Cherry");
fruits.Add("Cherry");
fruits.Add("Cherry");

Console.WriteLine(fruits.All(x => x == "Cherry"));
//Console.WriteLine(fruits.All(x => x.Age > 18));
