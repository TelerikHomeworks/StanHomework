using System;
/*You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/
class OddEvenProduct
{
    static void Main()
    {
        int oddProduct = 1;
        int evenProduct = 1;
        string[] tokens = Console.ReadLine().Split();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= int.Parse(tokens[i]);
            }
            else
            {
                evenProduct *= int.Parse(tokens[i]);
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}