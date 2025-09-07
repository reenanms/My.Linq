# My.LINQ

This project was created during a training session for my team to demonstrate how LINQ functions can be implemented using class extensions and `IEnumerable<T>`.  
It provides simple implementations of some core LINQ methods, such as `Where` and `Any`, to help understand the mechanics behind LINQ and extension methods in C#.

## Project Structure

- **My.Linq/**  
  Contains the LINQ extension methods ([LinqExtensions.cs](My.Linq/LinqExtensions.cs)).

- **My.Linq.Test/**  
  Contains unit tests for the extension methods ([LinqExtensions.cs](My.Linq.Test/LinqExtensions.cs)).

## How It Works

The extension methods are implemented as static methods in the [`My.Linq.LinqExtensions`](My.Linq/LinqExtensions.cs) class.  
You can use them directly on any `IEnumerable<T>` collection.

Example:
```csharp
var numbers = new[] { 1, 2, 3, 4, 5 };
var filtered = numbers.Where(n => n < 4); // returns 1, 2, 3
var hasAny = numbers.Any(); // returns true