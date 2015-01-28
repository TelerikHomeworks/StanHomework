using System;
//Write a program that finds the biggest of five numbers by using only five if statements.
class BiggestNumber
{
    static void Main()
    {
        float[] numbers = new float[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number {0} >> ", i+1);
            numbers[i] = float.Parse(Console.ReadLine());
        }
        float max = numbers[0];
        for (int i = 1; i < 5; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            } 
        }
        Console.WriteLine("The biggest number is ----->> {0}", max);
    }
}