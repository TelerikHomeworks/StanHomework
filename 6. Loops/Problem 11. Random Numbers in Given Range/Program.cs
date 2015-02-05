using System;
/*Write a program that enters 3 integers n, min and max (min != max) 
 * and prints n random numbers in the range [min...max].*/
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int n, min, max;
        Console.Write("N: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("min: ");
        min = int.Parse(Console.ReadLine());
        Console.Write("max: ");
        max = int.Parse(Console.ReadLine());
        int number = rnd.Next(min, max);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(number + " ");
            number = rnd.Next(min, max);
        }
    }
}