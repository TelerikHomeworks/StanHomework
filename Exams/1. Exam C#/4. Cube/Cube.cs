using System;

class Cube
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write((new string(' ', n - 1)) + (new string(':', n)) + "\n");
        for (int i = 0; i < n - 2; i++)
        {
            int space = n - 2 - i;
            Console.Write(new string(' ', space));
            Console.Write(':');
            Console.Write(new string('/', n - 2));
            Console.Write(':');
            Console.Write(new string('X', i));
            Console.Write(':');
            Console.WriteLine();
        }
        Console.WriteLine((new string(':', n)) + (new string('X', n - 2)) + ":");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(":");
            Console.Write(new string(' ', n - 2));
            Console.Write(":");
            Console.Write(new string('X', n - 3 - i));
            Console.Write(":");
            Console.WriteLine();
        }
        Console.WriteLine(new string(':', n));
    }
}
