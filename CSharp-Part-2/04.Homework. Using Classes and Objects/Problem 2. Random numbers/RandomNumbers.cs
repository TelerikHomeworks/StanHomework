using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Random_numbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] randomNumbers = new int[10];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(100, 201);
                Console.WriteLine(randomNumbers[i]);
            }
        }
    }
}
