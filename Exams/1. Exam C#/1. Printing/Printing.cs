using System;

class Printing
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint S = uint.Parse(Console.ReadLine());
        decimal P = decimal.Parse(Console.ReadLine());
        uint sheetsOfPapers = N * S;
        decimal reams = (decimal)sheetsOfPapers / (decimal)500;
        decimal prize = reams * P;
        Console.WriteLine("{0:0.00}", prize);
    }
}

