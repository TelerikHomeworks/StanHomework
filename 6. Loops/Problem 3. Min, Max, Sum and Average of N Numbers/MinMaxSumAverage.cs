using System;
/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/
class MinMaxSumAverage
{
    static void Main()
    {
        int min, max, sum = 0, number;
        double avg;
        Console.Write("Enter N > 0: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        sum += number;
        min = number;
        max = number;
        for (int i = 1; i < n; i++)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
            sum += number;
        }
        avg = (double)sum / (double)n;
        Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:0.00}",min, max, sum, avg);
    }
}