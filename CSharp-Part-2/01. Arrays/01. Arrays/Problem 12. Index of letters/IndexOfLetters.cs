using System;
/*Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.*/
class IndexOfLetters
{
    static void Main()
    {
        char[] array = new char[26];
        for (int i = 0; i < 26; i++)
        {
            array[i] = (char)(65 + i);
        }
        Console.Write("Enter a word -->> ");

        string word = Console.ReadLine();
        int length = 0;

        while (length < word.Length)
        {
            char currentLetter = word[length];
            for (int i = 0; i < 26; i++)
            {
                if (currentLetter == array[i])
                {
                    Console.Write(i + " ");
                    break;
                }
            }
            length++;
        }
        Console.WriteLine();
    }
}