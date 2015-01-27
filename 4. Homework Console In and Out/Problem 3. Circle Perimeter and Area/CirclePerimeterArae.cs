using System;
/*Write a program that reads the radius r of a circle and prints its perimeter and 
area formatted with 2 digits after the decimal point. */
class CirclePerimeterArae
{
    static void Main()
    {
        const double Pi = 3.14f;
        Console.Write("Radius r of a circle: ");
        double radius = float.Parse(Console.ReadLine());
        double perimeter = 2 * Pi * radius;
        double area = Pi * radius * radius;
        Console.WriteLine("Perimeter: {0:0.00} \nArea: {1:0.00}", perimeter, area);
    }
}