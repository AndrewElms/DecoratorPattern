using System;

/// <summary>
/// https://www.dotnettricks.com/learn/designpatterns/decorator-design-pattern-dotnet
/// </summary>
namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Foo";
            string s2 = "Bar";
            
            var concatenator = new Concatenator();
            var decoratedConcatenator = new ImprovedConcatenator(concatenator);

            // Call the base Concatenator to show it will concatenate the two strings
            string result1 = concatenator.Concatenate(s1, s2);
            Console.WriteLine(result1);

            Console.WriteLine();

            // Call the decorated Concatenator to let it add its functionality before it calls the base concatenator to concatenate the two strings
            string result2 = decoratedConcatenator.Concatenate(s1, s2);
            Console.WriteLine(result2);
        }
    }
}
