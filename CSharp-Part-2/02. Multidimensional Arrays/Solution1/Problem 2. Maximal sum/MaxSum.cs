using System;
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3
//that has maximal sum of its elements.
class MaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter M: ");
        int M = int.Parse(Console.ReadLine());

        int[,] array = new int[N, M];
        for (int row = 0; row < M; row++)
        {
            for (int col = 0; col < N; col++)
            {
                array[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int max = Int16.MinValue;

        for (int row = 0; row < N - 2; row++)
        {
            for (int col = 0; col < M - 2; col++)
            {
                int currentSum = array[row, col] + array[row, col + 1] + array[row, col + 2] + array[row + 1, col] + array[row + 1, col + 1] + array[row + 1, col + 2] + array[row + 2, col] + array[row + 2, col + 1] + array[row + 2, col + 2];

                if (currentSum > max)
                {
                    max = currentSum;
                }
            }
        }
    }
}