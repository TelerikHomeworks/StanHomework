using System;

class ExtractBitFromInt
{
    static void Main()
    {

        int haystack;
        int position;
        int m = 1;

        Console.WriteLine("Please, enter integer:");
        while (!int.TryParse(Console.ReadLine(), out haystack))
        {
            Console.WriteLine("Please, enter correct integer.");
        }
        Console.WriteLine("Please, set the bit position you are interested in:");
        while (!int.TryParse(Console.ReadLine(), out position))
        {
            Console.WriteLine("Please, enter correct integer.");
        }

        int mask = m << position;
        int result = mask & haystack;
        Console.WriteLine("\n#{0} bit is {1}", position, result >> position);
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}