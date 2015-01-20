using System;
/*
     * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:
        Number a        Number b        Equal (with precision eps=0.000001)     Explanation
        5.3     6.01    false               The difference of 0.71 is too big (> eps)
        5.00000001      5.00000003      true    The difference 0.00000002 < eps
        5.00000005      5.00000001      true    The difference 0.00000004 < eps
        -0.0000007      0.00000007      true    The difference 0.00000077 < eps
        -4.999999       -4.999998       false   Border case. The difference 0.000001 == eps. We consider the numbers are different.
        4.999999        4.999998        false   Border case. The difference 0.000001 == eps. We consider the numbers are different.
     */
class ComparingFloats
{
    static void Main()
    {

        decimal eps = 0.000001M;
        Console.Write("Enter number a: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal difference = Math.Abs(a - b);
        if (difference < eps)
        {
            Console.WriteLine("true \nThe difference {0} < eps\n", difference);
        }
        else if (difference > eps)
        {
            Console.WriteLine("false \nThe difference of {0} is too big (> eps)", difference);
        }
        else
        {
            Console.WriteLine("false \nBorder case. The difference 0.000001 == eps. We consider the numbers are different.");
        }
    }
}

