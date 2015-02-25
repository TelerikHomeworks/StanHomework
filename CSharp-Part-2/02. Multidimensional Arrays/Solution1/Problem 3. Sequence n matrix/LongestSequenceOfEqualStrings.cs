﻿using System;

class LongestSequenceOfEqualStrings
{
    public static void Main()
    {
        int[] dirRow = { 1, 0, 1, -1 };
        int[] dirCol = { 0, 1, 1, 1 };

        string[,] matrix = { { "ha", "fifi", "ho", "hi" },
                                 { "fo", "ha", "hi", "xx" },
                                 { "xxx", "ho", "ha", "xx" } };

        int bestLen = 0;
        string bestString = string.Empty;
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                string currentStr = matrix[row, col];
                int currentLen = 1;

                // dir change
                for (int direction = 0; direction < 4; direction++)
                {
                    int currentRow = row;
                    int currentCol = col;
                    while (true)
                    {
                        currentCol += dirCol[direction];
                        currentRow += dirRow[direction];

                        if (currentCol < 0 ||
                            currentCol >= numCols ||
                            currentRow < 0 ||
                            currentRow >= numRows ||
                            currentStr != matrix[currentRow, currentCol])
                        {
                            break;
                        }

                        currentLen++;

                        // Check best length
                        if (currentLen >= bestLen)
                        {
                            bestLen = currentLen;
                            bestString = currentStr;
                        }
                    }
                }
            }
        }

        Console.WriteLine("The longest sequence is - \"{0}\", with length - {1}", bestString, bestLen);
    }
}
