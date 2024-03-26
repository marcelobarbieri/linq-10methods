# 10 métodos do LINQ que todo programador .NET precisa saber

[![](./Assets/Images/youtube.png)](https://www.youtube.com/watch?v=b0g2noP5BzU)

## 1. First

> Recuperar o primeiro registro encontrado

```
dotnet new console -o First
```

Program.cs:

```c#
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

Console.WriteLine(fruits.First()); 
```

```
dotnet run

Cereja
```
### 1.1. FirstOrDefault

> Recuperar o primeiro registro encontrado ou o valor padrão

```
dotnet new console -o FirstOrDefault
```

Program.cs:

```c#
using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string>();
// fruits.Add("Cereja");
// fruits.Add("Abacaxi");
// fruits.Add("Maçã");
// fruits.Add("Pessego");
// fruits.Add("Mirtilo");
// fruits.Add("Coco");
// fruits.Add("Banana");

Console.WriteLine(fruits.FirstOrDefault("Não encontrado")); 
```

```
dotnet run

Não encontrado
```

## 2. Any

> Verificar se um elemento existe

```
dotnet new console -o Any
```

Program.cs:

```c#
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

Console.WriteLine(fruits.Any(x => x == "Cereja"));
// fruits.Where(x => x == "").Count() == 1;
```

```
dotnet run

True
```

## 3. All

> Verificar se todos os elementos são de um tipo

```
dotnet new console -o All
```

Program.cs:

```c#
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
```

```
dotnet run

True
```