using System;
/*
 * Using bitwise operators, write an expression for finding the value of the bit #3
 * of a given unsigned integer.
 * The bits are counted from right to left, starting from bit #0.
 * The result of the expression should be either 1 or 0.
 */
class ExtractBitAtPos3
{
    static void Main()
    {
        byte mask = 1 << 3;
        uint haystack;
        Console.WriteLine("Please, enter unsigned integer:");
        while (!uint.TryParse(Console.ReadLine(), out haystack))
        {
            Console.WriteLine("Please, enter correct integer.");
        }
        uint result = mask & haystack;
        Console.WriteLine("\n#3 bit is {0}", result >> 3);
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}