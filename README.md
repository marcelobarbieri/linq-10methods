# 10 LINQ methods that every .NET programmer needs to know

[![](./Assets/Images/youtube.png)](https://www.youtube.com/watch?v=b0g2noP5BzU)

## 1. First

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
### 1.1. FirstOrDefault

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

## 2. Any

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