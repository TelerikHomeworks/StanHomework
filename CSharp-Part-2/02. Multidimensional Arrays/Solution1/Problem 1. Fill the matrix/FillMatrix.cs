using System;

class FillMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int br = 1;
        Console.WriteLine("Enter a number for desired matrix: \n 1 for a) \n 2 for b) \n 3 for c) \n 4 for d*)");
        Console.WriteLine();
        Console.Write("Your choice -->> ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int startRow = 0;
        int startCol = 0;
        int endRow = n - 1;
        int endCol = n - 1;

        switch (choice)
        {
            case 1:   /// Matrix a)
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        array[row, col] = br;
                        br++;
                    }
                } break;
                
            case 2:  /// Matrix b)
                for (int col = 0; col < n; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            array[row, col] = br;
                            br++;
                        }
                    }
                    else
                    {
                        for (int row = n - 1; row >= 0; row--)
                        {
                            array[row, col] = br;
                            br++;
                        }
                    }
                } break;

            case 3:  /// Matrix c)
                for (int row = n - 1; row >= 0; row--)
                {
                    int rowCurr = row;
                    for (int col = 0; col < n; col++)
                    {
                        if (rowCurr != n - 1)
                        {
                            array[rowCurr, col] = br;
                            rowCurr++;
                            br++;
                        }
                        else
                        {
                            array[rowCurr, col] = br;
                            br++;
                            break;
                        }
                    }
                }
                for (int col = 1; col < n; col++)
                {
                    int currCol = col;
                    for (int row = 0; row < n - 1; row++)
                    {
                        if (currCol != n - 1)
                        {
                            array[row, currCol] = br;
                            currCol++;
                            br++;
                        }
                        else
                        {
                            array[row, currCol] = br;
                            br++;
                            break;
                        }
                    }
                } break;

            case 4:  /// Matrix d*)

                while (br <= n * n)
                {

                    for (int row = startRow; row <= endRow; row++)
                    {
                        array[row, startCol] = br;
                        br++;
                    }
                    startCol++;
                    for (int col = startCol; col <= endCol; col++)
                    {
                        array[endRow, col] = br;
                        br++;
                    }
                    endRow--;
                    for (int row = endRow; row >= startRow; row--)
                    {
                        array[row, endCol] = br;
                        br++;
                    }
                    endCol--;
                    for (int col = endCol; col >= startCol; col--)
                    {
                        array[startRow, col] = br;
                        br++;
                    }
                    startRow++;
                }
                break;
            
            default: break;
        }

        //Output the Matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}