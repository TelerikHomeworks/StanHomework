using System;
/*In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 * (also known as the number of combinations) is calculated by the following formula: formula For example,
 * there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k 
 * (1 < k < n < 100). Try to use only two loops.*/

class CalcFactExpression
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
        Console.WriteLine("N!*K!/(K-N)! = {0}", (calcFact(N) / ((calcFact(K) * calcFact(N - K)))));
    }
}