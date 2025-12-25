using System.Linq;
Console.WriteLine("int collections");

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Filtering with LINQ
var numbersAboveFive = numbers.Where(number => number > 5);