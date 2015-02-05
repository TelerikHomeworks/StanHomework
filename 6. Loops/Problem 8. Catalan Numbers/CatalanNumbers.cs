using System;
using System.Numerics;
class CatalanNumbers
{
    public static BigInteger calcFact(int num)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger temp = 1;
        for (int i = n + 2; i <= 2 * n; i++)
        {
            temp *= i;
        }

        Console.WriteLine("C({0}) = {1}", n, (temp / (calcFact(n))));
    }
}