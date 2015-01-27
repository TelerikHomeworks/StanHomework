using System;
/*Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/
class Program
{
    static void Main()
    {
        float sum = 0;
        string[] tokens = Console.ReadLine().Split();
        for (int i = 0; i < tokens.Length; i++)
        {
            sum += float.Parse(tokens[i]);
        }
        Console.WriteLine(sum);
    }
}