using System.Linq;
using LinqDemo;

internal class Program
{
    public static void Main(string[] args)
    {
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

        Console.WriteLine("----------String Collections-----------");

        var names = new string[] { "Aaron", "Clara", "Maddie", "Peter", "Evan", "Julia", "Aly" };

//Filtering using strings
        Console.WriteLine("* longerNames *");
        var longerNames = names.Where(x => x.Length > 4).ToArray();

        foreach (var name in longerNames)
        {
            Console.WriteLine(name);
        }

//Transforming with LINQ
        Console.WriteLine("* upperCaseNames * ");
        var upperCaseNames = names.Select(x => x.ToUpper().ToArray());

        foreach (var name in upperCaseNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("---------Ordering Things----------");

        Console.WriteLine("* orderedNames *");
        var orderedNames = names.OrderBy(name => name.Length).ToArray();

        foreach (var name in orderedNames)
        {
            Console.WriteLine(name);
        }
// ThenBy and using a class
        Console.WriteLine("--------------------");

        var dogOne = new Dog()
        {
            Name = "Rhoadie",
            Age = 5
        };

        var dogTwo = new Dog()
        {
            Name = "Cici",
            Age = 14
        };

        var dogThree = new Dog()
        {
            Name = "Cici",
            Age = 3
        };

        var dogPark = new List<Dog> { dogOne, dogTwo, dogThree };
        var orderedDogs = dogPark.OrderBy(dog => dog.Name).ThenBy(dog => dog.Age).ToList();
        foreach (var dog in orderedDogs)
        {
            Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}");
        }
    }
}