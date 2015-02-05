using System;
    class GreatestCommonDivisor
    {
        public static int gcd(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }

            }
            return num1;
        }
        static void Main(string[] args)
        {
            Console.Write("Num 1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Num 2 = ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(gcd(num1, num2));
        }
    }