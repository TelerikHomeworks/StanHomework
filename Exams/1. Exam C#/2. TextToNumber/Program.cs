using System;

class Program
{
    static void Main()
    {
        int RESULT = 0;
        int M = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                Console.WriteLine(RESULT);
                break;
            }
            if (65 <= text[i] && text[i] <= 90)
            {
                RESULT += text[i] - 'A';
            }
            else if (97 <= text[i] && text[i] <= 122)
            {
                RESULT += text[i] - 'a';
            }
            else if (48 <= text[i] && text[i] <= 57)
            {
                RESULT *= text[i] - '0';
            }
            else
            {
                RESULT = RESULT % M;
            }
        }
    }
}