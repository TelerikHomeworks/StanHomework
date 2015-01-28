using System;
//Write a program that finds the biggest of three numbers.
class BiggestNumber
{
    static void Main()
    {
        float a, b, c;
        float max;
        Console.Write("Enter a: ");
        a = float.Parse(Console.ReadLine());
        max = a;
        Console.Write("Enter b: ");
        b = float.Parse(Console.ReadLine());
        if (max < b)
        {
            max = b;
        }
        Console.Write("Enter c: ");
        c = float.Parse(Console.ReadLine());
        if (max < c)
        {
            max = c;
        }
        Console.WriteLine("The biggest number is: {0}", max);
    }
}