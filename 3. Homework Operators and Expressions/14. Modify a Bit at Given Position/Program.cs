using System;

/*
 * We are given an integer number n, a bit value v (v=0 or 1) and a position p.
 * Write a sequence of operators (a few lines of C# code) that modifies n
 * to hold the value v at the position p from the binary representation of n
 * while preserving all other bits in n.
 */
class ModifyBitAtPos
{
    static void Main()
    {
        int haystack;
        int position;
        int setTo;

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
        Console.WriteLine("Provide the bit value you like to be set:");
        while (!int.TryParse(Console.ReadLine(), out setTo) && (setTo != 0 || setTo != 1))
        {
            Console.WriteLine("Please, enter correct integer.");
        }
        int mask = 1;

        bool boolResult = (haystack & (1 << position)) != 0;
        //Console.WriteLine(boolResult);

        if ((setTo == 1 && boolResult) || (setTo == 0 && !boolResult))
        {
            Console.WriteLine(haystack);
        }
        else if ((setTo == 1 && !boolResult) || (setTo == 0 && boolResult))
        {
            Console.WriteLine(haystack ^ (mask << position));
        }
        Console.ReadKey();
    }
}