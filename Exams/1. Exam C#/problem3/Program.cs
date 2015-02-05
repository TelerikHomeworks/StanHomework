using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        string publicNumber = Console.ReadLine();
        int count = 0;
        int sum = 0;
        while (true)
        {
            BigInteger product = 1;
            for (int j = 2; j <= publicNumber.Length; j++)
            {
                sum = 0;
                for (int i = publicNumber.Length - j; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        sum += (int)publicNumber[i] - '0';
                    }
                }
                product *= sum;
            }
            count++;
            if (count == 10)
            {
                Console.WriteLine(product);
                break;
            }
            else if (product < 10)
            {
                Console.WriteLine(count);
                Console.WriteLine(product);
                break;
            }
            publicNumber = Convert.ToString(product);
        }
    }
}