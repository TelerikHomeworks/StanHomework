using System;
/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/
class CalculateSum
{
    static int Fact(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
    static void Main()
    {
        int n, x;
        double sum = 1;
        Console.Write("Enter n: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            sum += Fact(i) / (double)Math.Pow(x, i);
        }
        Console.WriteLine("{0:0.00000}", sum);
    }
}