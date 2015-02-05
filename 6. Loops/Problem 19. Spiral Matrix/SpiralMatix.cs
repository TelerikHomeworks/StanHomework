﻿using System;

class SpiralMatix
{
    static void Main()
    {
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int counter = 1;
        int startRow = 0;
        int endRow = N - 1;
        int startCol = 0;
        int endCol = N - 1;

        while (counter <= N * N)
        {
            for (int col = startCol; col <= endCol; col++)
            {
                matrix[startRow, col] = counter;
                counter++;
            }
            startRow++;
            for (int row = startRow; row <= endRow; row++)
            {
                matrix[row, endCol] = counter;
                counter++;
            }
            endCol--;
            for (int col = endCol; col >= startCol; col--)
            {
                matrix[endRow, col] = counter;
                counter++;
            }
            endRow--;
            for (int row = endRow; row >= startRow; row--)
            {
                matrix[row, startCol] = counter;
                counter++;
            }
            startCol++;
        }

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                Console.Write("{0,3} ", matrix[row, col], 6);
            }
            Console.WriteLine();
        }
    }
}