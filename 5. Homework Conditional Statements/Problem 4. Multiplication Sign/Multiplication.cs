using System;
/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.*/
class Multiplication
{
    static void Main()
    {
        int countNegative = 0;
        float a, b, c;
        Console.Write("Enter a: ");
        a = float.Parse(Console.ReadLine());
        if (a < 0)
        {
            countNegative++;
        }
        Console.Write("Enter b: ");
        b = float.Parse(Console.ReadLine());
        if (b < 0)
        {
            countNegative++;
        }
        Console.Write("Enter c: ");
        c = float.Parse(Console.ReadLine());
        if (c < 0)
        {
            countNegative++;
        }
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if (countNegative % 2 != 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}