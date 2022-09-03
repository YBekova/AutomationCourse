using System;



namespace Lesson1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string number 1: ");
            string firstString = Console.ReadLine().ToUpper();
            Console.WriteLine($"Formatted string number 1: {firstString}");
            
            Console.WriteLine("Enter string number 2: ");
            string secondString = Console.ReadLine().ToUpper();
            Console.WriteLine($"Formatted string number 2: {secondString}");

            Console.WriteLine("Enter string number 3: ");
            string thirdString = Console.ReadLine().ToUpper();
            Console.WriteLine($"Formatted string number 3: {thirdString}");

            Boolean result1 = firstString.StartsWith(secondString); // начинается ли первая строка со второй?
            Boolean result2 = firstString.EndsWith(thirdString); // заканчивается ли первая строка третьей? 

            
            
            Console.WriteLine($"String {firstString} startsfrom {secondString}: {result1}");
            Console.WriteLine($"String {firstString} ends with {thirdString}: {result2}");




            Console.ReadKey();
        }
    }
}
