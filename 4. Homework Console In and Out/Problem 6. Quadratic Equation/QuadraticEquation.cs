using System;
/*Write a program that reads the coefficients a, b and c
 * of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficent a: ");
        double a = float.Parse(Console.ReadLine());
        Console.Write("Enter coefficent b: ");
        double b = float.Parse(Console.ReadLine());
        Console.Write("Enter coefficent c: ");
        double  c = float.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);
        double x1 = (-b - Math.Sqrt(d)) / (2 * a);
        double x2 = (-b + Math.Sqrt(d)) / (2 * a);
        Console.WriteLine("Roots: x1 = {0} x2 = {1}", x1, x2);
    }   
}