using System;
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter is: {0}    Area is {1} ", (2 * width + 2 * height), (width * height));
    }
}