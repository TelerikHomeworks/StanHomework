using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        string publicNumber = Console.ReadLine();
        int count = 0;
        BigInteger product = 1;
        long Num = long.Parse(publicNumber);
        int length = Convert.ToString(Num).Length;
        while (true)
        {
            while (length != 1)
            {
                int EvenCount = 0;
                int sum = 0;
                Num /= 10;
                length = Convert.ToString(Num).Length;
                for (int i = 0; i < length; i++)
                {
                    if (EvenCount % 2 == 0)
                    {
                        sum += Convert.ToString(Num)[i] - '0';
                    }
                    EvenCount++;
                }
                product *= sum;
            }
            count++;
            BigInteger newNumber = product;
            if (newNumber < 10)
            {
                Console.WriteLine(count);
                Console.WriteLine(newNumber);
                break;
            }
        }
    }
}