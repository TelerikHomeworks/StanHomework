using System;
using System.Numerics;

class ZerosAtTheEnd
{
    public static BigInteger calcFact(int num)
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
        int zerosCount = 0;
        BigInteger lastDigit = calcFact(N);
        if (calcFact(N) % 10 == 0)
        {
            while (lastDigit % 10 == 0)
            {
                zerosCount++;
                lastDigit /= 10;
            }
        }
        Console.WriteLine("The count of zeros at the end is {0}", zerosCount);
    }
}