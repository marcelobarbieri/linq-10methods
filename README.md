# 10 LINQ methods that every .NET programmer needs to know

[![](./Assets/Images/youtube.png)](https://www.youtube.com/watch?v=b0g2noP5BzU)

<details><summary>1. FIRST</summary>

> Recover the first record found

```
dotnet new console -o First
```

Program.cs:

```c#
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

Console.WriteLine(fruits.First()); 
```

```
dotnet run

Cherry
```

<details><summary>1.1. FIRST OR DEFAULT</summary>

> Recover the first record found or the default value

```
dotnet new console -o FirstOrDefault
```

Program.cs:

```c#
using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
// fruits.Add("Cherry");
// fruits.Add("Pineapple");
// fruits.Add("Litter");
// fruits.Add("Peach");
// fruits.Add("Blueberry");
// fruits.Add("Coconut");
// fruits.Add("Banana");

Console.WriteLine(fruits.FirstOrDefault("Not found")); 
```

```
dotnet run

Not found
```
</details>

</details>

<details><summary>2. ANY</summary>

> Check if an element exists

```
dotnet new console -o Any
```

Program.cs:

```c#
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

Console.WriteLine(fruits.Any(x => x == "Cherry"));
// fruits.Where(x => x == "").Count() == 1;
```

```
dotnet run

True
```

</details>

<details><summary>3. ALL</summary>

## 3. All

> Check that all elements are of a type

```
dotnet new console -o All
```

Program.cs:

```c#
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
```

```
dotnet run

True
```

</details>

<details><summary>4. COUNT</summary>

## 4. Count

> Lenght is the basic type

> Count is the optimized type

```
dotnet new console -o Count
```

Program.cs:

```c#
using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
fruits.Add("Cherry");
fruits.Add("Cherry");

fruits.Add("Pineapple");
fruits.Add("Litter");
fruits.Add("Peach");
fruits.Add("Blueberry");
fruits.Add("Coconut");
fruits.Add("Banana");

Console.WriteLine(fruits.Count); // Preferível
// Console.WriteLine(fruits.Count());
Console.WriteLine(fruits.Count(x => x == "Cherry")); 
```

```
dotnet run

8
2
```

</details>

<details><summary>5. ELEMENT AT</summary>

## 5. ElementAt 

> Search by an index (zero based)

> Used in pagination, for example. Instead of **IndexOf** and **Find**

```
dotnet new console -o ElementAt
```

Program.cs:

```c#
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

Console.WriteLine(fruits.ElementAt(5)); 
// Console.WriteLine(fruits.ElementAt(15)); // Exception
```

```
dotnet run

Coconut
```

</details>

<details><summary>6. TAKE</summary>

## 6. Take

> Works with **Range Operator** (i.e., First 3, Last 3, 1 to 3 zero based)

```
dotnet new console -o Take
```

Program.cs:

```c#
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

foreach (var fruit in fruits.Take(3))
    Console.WriteLine(fruit);
foreach (var fruit in fruits.Take(..3))    
    Console.WriteLine(fruit);
foreach (var fruit in fruits.Take(1..3))    
    Console.WriteLine(fruit);
```

```
dotnet run

Cherry
Pineaple
Litter

Blueberry
Coconut
Banana

Pineapple
Litter

```

</details>

<details><summary>7. WHERE</summary>

## 7. Where

```
dotnet new console -o Where
```

Program.cs:

```c#
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
```

```
dotnet run

Cherry
```

</details>

<details><summary>8. SINGLE</summary>

## 8. Single

> Expects only a element

```
dotnet new console -o Single
```

Program.cs:

```c#
using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
fruits.Add("Cherry");
fruits.Add("Cherry");

fruits.Add("Pineapple");
fruits.Add("Litter");
fruits.Add("Peach");
fruits.Add("Blueberry");
fruits.Add("Coconut");
fruits.Add("Banana");

Console.WriteLine(fruits.Single()); // Exception
Console.WriteLine(fruits.Single(x => x == "Cherry")); // Exception
Console.WriteLine(fruits.Single(x => x == "Pineapple"));
```

```
dotnet run

Exception
Exception
Pineapple
```

</details>

<details><summary>9. LAST</summary>

## 9. Last

```
dotnet new console -o Last
```

Program.cs:

```c#
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
```

```
dotnet run

Banana
Cherry
```

</details>

<details><summary>10. SKIP</summary>


## 10. Skip

```
dotnet new console -o Skip
```

Program.cs:

```c#
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

foreach (var fruit in fruits.Skip(3)) // not zero based
    Console.WriteLine(fruit); 
```

```
dotnet run

Peach
Blueberry
Coconut
Banana
```

</details>