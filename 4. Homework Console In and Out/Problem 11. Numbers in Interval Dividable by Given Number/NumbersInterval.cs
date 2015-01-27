using System;
/*Write a program that reads two positive integer numbers and prints how many numbers p 
 * exist between them such that the reminder of the division by 5 is 0.*/
class NumbersInterval
{
    static void Main()
    {
        Console.Write("Бeginning of the interval: ");
        uint beginning = uint.Parse(Console.ReadLine());
        Console.Write("End of the interval: ");
        uint end = uint.Parse(Console.ReadLine());
        int counter = 0;
        Console.WriteLine();
        for (uint i = beginning; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Number divided by 5: {0}", i);
                counter++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The numbers in [ {0} ; {1} ] divided by 5 ----> {2}", beginning, end, counter);
        Console.ReadLine();
    }
}