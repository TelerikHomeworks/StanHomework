using System;
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter X coordinate of Point: ");
        float xCoordinate = float.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate of Point: ");
        float yCoordinate = float.Parse(Console.ReadLine());
        Console.Write("Point is in circle ---> ");
        Console.WriteLine((Math.Sqrt(xCoordinate * xCoordinate + yCoordinate * yCoordinate) <= 2)? "true":"false");
    }
}