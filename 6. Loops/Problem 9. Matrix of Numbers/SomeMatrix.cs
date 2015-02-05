﻿using System;
/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
 * like in the examples below. Use two nested loops.*/
class SomeMatrix
{
    static void Main()
    {
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int counter = 1;
        //Fill the matrix
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                matrix[row, col] = counter;
                counter++;
            }
            counter -= (N - 1);
        }
        //Show the matrix
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                Console.Write("{0,2} ", matrix[row, col], 6);
            }
            Console.WriteLine();
        }

    }
}