using System;

class Program
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

