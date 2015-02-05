using System;
using System.Numerics;
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
class FactorialDivision
{
    public static int calcFact(int num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("N!/K! = {0}", calcFact(N) / calcFact(K));
    }
}