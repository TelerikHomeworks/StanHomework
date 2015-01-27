using System;
//Write a program that reads 3 real numbers from the console and prints their sum.
class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers in console");
        Console.Write("Enter a real number: ");
        float a; // number 1 
        while (!float.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid input! Enter a correct number: ");
        }
        Console.Write("Enter a real number: ");
        float b; // number 2
        while (!float.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid input! Enter a correct number: ");
        }
        Console.Write("Enter a real number: ");
        float c; // number 3
        while (!float.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid input! Enter a correct number: ");
        }
        Console.WriteLine("Sum of numbers is {0}", a + b + c);
    }
}