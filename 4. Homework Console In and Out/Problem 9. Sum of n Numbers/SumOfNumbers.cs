using System;
///Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
class SumOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter count of numbers: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        float sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("number {0} -->\t", i + 1);
            sum += float.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Sum of numbers   - -- - >>\t");
        Console.WriteLine(sum);
        Console.WriteLine();
    }
}