using System;


namespace Lesson1_Task;

internal class Program
{
    static void Main()
    {

        Console.Write("x = ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.Write("z = ");
        double z = Convert.ToDouble(Console.ReadLine());

        double result1 = (x + y) * (1 + Math.Sqrt(z));
        Console.WriteLine($"First expression result: {result1}");

        double result2 = (x % z - 1) * Math.Sqrt(y);
        Console.WriteLine($"Second expression result: {result2}");

        double result3 = (x * y + y * z) / Math.Pow(z, 3);
        Console.WriteLine($"Third expression result: {result3}");

        Console.ReadKey();


    }
}

