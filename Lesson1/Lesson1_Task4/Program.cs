using System;



namespace Lesson1_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string ");
            String firstString = Console.ReadLine();
           
            Console.WriteLine("Enter the second string "); 
            String secondString = Console.ReadLine();


            Console.WriteLine("Enter the symbol string ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine();

            string concatString = String.Concat(firstString, secondString);
            int index = concatString.LastIndexOf(symbol);

            Console.WriteLine($"Index of {symbol} in {concatString} : {index}");


            Console.ReadKey();
        }
    }
}