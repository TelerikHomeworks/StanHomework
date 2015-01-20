using System;

class PrintSequence
{
    static void Main(string[] args)
    {
        int positiveNumber = 2; //first positive number fof sequence
        int negativeNumber = -3; //first negative number of sequence
        for (int i = 0; i < 5; i++) //write sequence in console
        {
            Console.Write(positiveNumber + " " + negativeNumber + " ");
            positiveNumber += 2;
            negativeNumber -= 2;
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}