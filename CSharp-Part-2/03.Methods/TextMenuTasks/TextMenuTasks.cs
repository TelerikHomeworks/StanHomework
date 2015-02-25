using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMenuTasks
{
    class TextMenuTasks
    {
        static void PrintMenu()
        {
            Console.WriteLine("1. Reverse the digits of a non negative number.    ");
            Console.WriteLine("2. Calculate the avarage of a sequence of integers.");
            Console.WriteLine("3. Solve a linear equation a * x + b = 0 .         ");

            Console.Write("Choose a task number: ");
        }

        static int ReverseDigits(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                reversed = (reversed * 10) + (number % 10);
                number /= 10;
            }
            return reversed;
        }

        static int CalculateAverage(int[] sequence)
        {
            int sequenceLength = sequence.GetLength(0);
            int sum = 0;
            foreach (int x in sequence)
            {
                sum += x;
            }

            return sum / sequenceLength;
        }

        static double SolveEquation(double a, double b)
        {
            double result = -b / a;
            return result;
        }


        static void Main(string[] args)
        {
            PrintMenu();

            int chosenTask = int.Parse(Console.ReadLine());

            switch (chosenTask)
            {
                case 1:
                    Console.Write("Enter a non-negative number: ");
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        Console.WriteLine("The number you have entered is negative.");
                    }
                    else
                    {
                        int reversed = ReverseDigits(number);
                        Console.WriteLine("The reversed number is: {0}", reversed);
                    }
                    break;

                case 2:
                    Console.Write("Enter the length of the integer sequence: ");
                    int sequenceLength = int.Parse(Console.ReadLine());

                    if (sequenceLength <= 0)
                    {
                        Console.WriteLine("Invalid length.");
                    }
                    else
                    {
                        int[] sequence = new int[sequenceLength];
                        Console.WriteLine("Enter the elements of the sequence:");

                        for (int i = 0; i < sequenceLength; ++i)
                        {
                            sequence[i] = int.Parse(Console.ReadLine());
                        }

                        int average = CalculateAverage(sequence);
                        Console.WriteLine("The average is: {0}", average);
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the coefficients of the equation:");
                    Console.Write("a = ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("b = ");
                    double b = double.Parse(Console.ReadLine());

                    if (a == 0.0 && b != 0.0)
                    {
                        Console.WriteLine("The equation can't be solved because a = 0 and b != 0");
                    }
                    else if (a == 0.0 && b == 0.0)
                    {
                        Console.WriteLine("Every x is solution to the equation.");
                    }
                    else
                    {
                        double result = SolveEquation(a, b);
                        Console.WriteLine("The root x = {0}", result);
                    }
                    break;
                default: Console.WriteLine("Invalid task!"); break;
            }

        }
    }
}
