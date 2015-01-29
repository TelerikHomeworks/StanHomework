using System;
/*Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.*/
class NumberWords
{
    static string UppercaseFirst(string s)
    {
        // Check for empty string.
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        // Return char and concat substring.
        return char.ToUpper(s[0]) + s.Substring(1);
    }
    static string OneDigitNumbers(int n)
    {
        string digit;
        switch (n)
        {
            case 0: digit = ""; break;
            case 1: digit = "one"; break;
            case 2: digit = "two"; break;
            case 3: digit = "three"; break;
            case 4: digit = "four"; break;
            case 5: digit = "five"; break;
            case 6: digit = "six"; break;
            case 7: digit = "seven"; break;
            case 8: digit = "eight"; break;
            case 9: digit = "nine"; break;
            default: digit = "";
                break;
        }
        return digit;
    }
    static string TwoDigitNumbers(int n)
    {
        string digit;
        switch (n)
        {
            case 2: digit = "twenty"; break;
            case 3: digit = "thirty"; break;
            case 4: digit = "forty"; break;
            case 5: digit = "fifty"; break;
            case 6: digit = "sixty"; break;
            case 7: digit = "seventy"; break;
            case 8: digit = "eighty"; break;
            case 9: digit = "ninety"; break;
            case 10: digit = "ten"; break;
            case 11: digit = "eleven"; break;
            case 12: digit = "twelve"; break;
            case 13: digit = "thirteen"; break;
            case 14: digit = "fourteen"; break;
            case 15: digit = "fifteen"; break;
            case 16: digit = "sixteen"; break;
            case 17: digit = "seventeen"; break;
            case 18: digit = "eighteen"; break;
            case 19: digit = "nineteen"; break;
            default: digit = "";
                break;
        }
        return digit;
    }

    static void Main()
    {
        Console.Write("Enter a number in the range [0…999] ---->> ");
        int number = -1;
        while (number < 0 || number > 999)
        {
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid intiger... \nEnter a new one in the range [0…999] ---->> ");
            }
            if (number < 0 || number > 999)
            {
                Console.Write("Out of range! \nPlease enter an integer in the range [0…999] ---->> ");
            }
        }
        Console.WriteLine();
        int count = Convert.ToString(number).Length;
        if (number == 0)
        {
            Console.Write("Number as word: Zero");
        }
        else if (count == 1)
        {
            Console.WriteLine("Number as word: " + UppercaseFirst(OneDigitNumbers(number)));
        }
        else if (count == 2)
        {
            if (number < 20)
            {
                Console.WriteLine("Number as word: " + UppercaseFirst(TwoDigitNumbers(number)));
            }
            else if(number %10 == 0)
            {
                string digit = TwoDigitNumbers(number / 10);
                Console.WriteLine("Number as word: " + UppercaseFirst(digit));
            }
            else
            {
                string digit = TwoDigitNumbers(number / 10) + "-" + OneDigitNumbers(number % 10);
                Console.WriteLine("Number as word: " + UppercaseFirst(digit));
            }
        }
        else if (count == 3)
        {
            string digit = OneDigitNumbers(number / 100) + " hundred ";
            if (number / 10 % 10 != 0 || number % 10 != 0)
            {
                digit += "and ";
            }
            if (number % 100 < 20 && number % 100 >= 10)
            {
                digit += TwoDigitNumbers(number % 100);
            }
            else
            {
                if (number % 100 > 20 && number % 10 != 0)
                {
                    digit += TwoDigitNumbers((number % 100) / 10) + "-" + OneDigitNumbers(number % 10);
                }
                else
                {
                    digit += TwoDigitNumbers((number % 100) / 10) + "" + OneDigitNumbers(number % 10);
                }
            }
            Console.WriteLine("Number as words: " + UppercaseFirst(digit));
        }
        Console.WriteLine("");
    }
}