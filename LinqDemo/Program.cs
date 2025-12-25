using System.Linq;
Console.WriteLine("----------int collections----------");

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("* numbersAboveFive *");
//Filtering with LINQ
var numbersAboveFive = numbers.Where(number => number > 5).ToList(); // turned back into list with ToList

numbersAboveFive.ForEach(number => Console.WriteLine(number)); // ForEach() method only works with Lists

Console.WriteLine("* evenNumbers *");
//Filter
var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

evenNumbers.ForEach(x => Console.WriteLine(x)); 

Console.WriteLine("--------------------");

//Sum method
Console.WriteLine($"Sum: {numbers.Sum()}");

Console.WriteLine($"Average: {numbers.Average()}");

Console.WriteLine("-------------------");

// Min and Max methods
Console.WriteLine($"Min: {numbers.Min()}");

Console.WriteLine($"Max: {numbers.Max()}");

Console.WriteLine("---------Transforming-----------");

// Transform methods with LINQ (changing the values)

Console.WriteLine("* squaredNumbers *");
var squaredNumbers = numbers.Select(number => number * number).ToList();

squaredNumbers.ForEach(x => Console.WriteLine(x));
