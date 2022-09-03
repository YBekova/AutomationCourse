using System;

namespace Lesson1_Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Add one by one - Width, Height, Length - to see the results:");
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine($"Parallelepiped diagonal length: {diagonal}");

            Console.ReadKey();
        }
    }
}