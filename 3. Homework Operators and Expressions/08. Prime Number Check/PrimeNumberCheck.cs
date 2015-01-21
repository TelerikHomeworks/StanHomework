using System;
//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter a positive number less or equal to 100: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if ((number >= 0) && (number <= 100))
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("The number is not in interval [0 ; 100]");
            }
            Console.WriteLine("The number {0} is prime? ---> {1}", number, isPrime);
        }
    }