using System;
/*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.*/
class SortNumbers
{
    static void Main()
    {
        float a, b, c;
        Console.Write("Enter a: ");
        a = float.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        b = float.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        c = float.Parse(Console.ReadLine());

        if (a > b && a > c) //first main check if a is the biggest
        {
            if (b > c)
            {
                Console.WriteLine("Numbers in descending order -->>> {0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("Numbers in descending order -->>> {0} {1} {2}", a, c, b);
            }
        } //end
        else if (b > c && b > a) //second main check if b is the biggest
        {
            if (a > c)
            {
                Console.WriteLine("Numbers in descending order -->>> {0} {1} {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("Numbers in descending order -->>> {0} {1} {2}", b, c, a);
            }
        } //end
        else if (c > a && c > b) //third main check if c is the biggest
        {
            if (a > b)
            {
                Console.WriteLine("Numbers in descending order -->>> {0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("Numbers in descending order -->>> {0} {1} {2}", c, b, a);
            }
        } //end
    }
}