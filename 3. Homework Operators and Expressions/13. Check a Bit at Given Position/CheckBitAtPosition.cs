using System;

/*
 * Write a Boolean expression that returns if the bit at position p
 * (counting from 0, starting from the right) in given integer number n has value of 1.
 */

class CheckBitAtPosition
{
    static void Main()
    {
        int haystack;
        int position;

        Console.WriteLine("Please, enter unsigned integer:");
        while (!int.TryParse(Console.ReadLine(), out haystack))
        {
            Console.WriteLine("Please, enter correct integer.");
        }
        Console.WriteLine("Please, set the bit position you are interested in:");
        while (!int.TryParse(Console.ReadLine(), out position))
        {
            Console.WriteLine("Please, enter correct integer.");
        }

        bool boolResult = (haystack & (1 << position)) != 0;

        Console.WriteLine("\n#{0} bit {1}", position, boolResult);
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}