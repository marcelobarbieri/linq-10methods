using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
fruits.Add("Cereja");
fruits.Add("Abacaxi");
fruits.Add("Maçã");
fruits.Add("Pessego");
fruits.Add("Mirtilo");
fruits.Add("Coco");
fruits.Add("Banana");

// 1 - Primeiro Elemento
Console.WriteLine(fruits.First()); // Cereja
Console.WriteLine(fruits.FirstOrDefault("Não encontrado")); 