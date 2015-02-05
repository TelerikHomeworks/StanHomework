using System;
using System.Text;
class BitsToBits
{
    public static string IntToBinaryString(int number)
    {
        var binary = string.Empty;
        while (number > 0)
        {
            // Logical AND the number and prepend it to the result string
            binary = (number & 1) + binary;
            number = number >> 1;
        }
        return binary;
    }
    public static string addZeroes(string str)
    {
        int length = str.Length;
        int zeroes = 30 - length;
        string zeroesString = String.Format(new string('0', zeroes));
        string newString = String.Format(zeroesString + str);
        return newString;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countOfZeroes = 1;
        int countOfOnes = 1;
        int maxCountOfZeroes = 0;
        int maxCountOfOnes = 0;
        bool zero = false;
        bool one = false;
        StringBuilder wholeStringOfBits = new StringBuilder();
        string bitsWithZeroes;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            bitsWithZeroes = addZeroes(IntToBinaryString(number));
            wholeStringOfBits = wholeStringOfBits.Append(bitsWithZeroes);
        }
        for (int i = 0; i < wholeStringOfBits.Length - 1; i++)
        {
            if (wholeStringOfBits[i] == wholeStringOfBits[i + 1])
            {
                if (wholeStringOfBits[i] == '0')
                {
                    countOfZeroes++;
                    zero = true;
                }
                else if (wholeStringOfBits[i] == '1')
                {
                    countOfOnes++;
                    one = true;
                }
                if (countOfZeroes > maxCountOfZeroes)
                {
                    maxCountOfZeroes = countOfZeroes;
                }
                if (countOfOnes > maxCountOfOnes)
                {
                    maxCountOfOnes = countOfOnes;
                }
            }
            else
            {
                countOfZeroes = 1;
                countOfOnes = 1;
            }
        }
        if (zero == false && one == true)
        {
            Console.WriteLine(maxCountOfZeroes - 1);
            Console.WriteLine(maxCountOfOnes);
        }
        else if (one == false && zero == true)
        {
        Console.WriteLine(maxCountOfZeroes);
        Console.WriteLine(maxCountOfOnes - 1);
        }
        else
        {
            Console.WriteLine(maxCountOfZeroes);
            Console.WriteLine(maxCountOfOnes);
        }
        
    }
}