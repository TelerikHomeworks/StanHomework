using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter base A of the trapezoid: ");
        float baseA = float.Parse(Console.ReadLine());
        Console.Write("Enter base B of the trapezoid: ");
        float baseB = float.Parse(Console.ReadLine());
        Console.Write("Enter height of the trapezoid: ");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Are of the trapezoid is ---> {0}", ((baseA + baseB) * height) / 2);
    }
}

