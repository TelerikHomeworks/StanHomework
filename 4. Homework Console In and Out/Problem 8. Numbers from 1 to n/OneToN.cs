﻿using System;
/*Write a program that reads an integer number n from the console and prints all the numbers in the interval 
 * [1..n], each on a single line.
Note: You may need to use a for-loop.*/
class OneToN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i + 1);
        }
    }
}