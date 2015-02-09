using System;
//Write a program that compares two char arrays lexicographically (letter by letter).
class CompareCharArrays
{
    static void Main()
    {
        string arrayOne = Console.ReadLine();
        string arrayTwo = Console.ReadLine();
        bool equal = true;
        if (arrayOne.Length != arrayTwo.Length)
        {
            equal = false;
        }
        else
        {
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    equal = false;
                }
            }
        }
        Console.WriteLine(equal? "Arrays are equal." : "Arrays aren't equal.");
    }
}