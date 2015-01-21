using System;
//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Example 777877	false    ,       9999799	true

class ThirdDigitSeven
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number.ToString().Length < 3)
        {
            Console.WriteLine("Third digit 7? ---> false");
        }
        else
        {
            if (((number / 100) % 10) == 7)
            {
                Console.WriteLine("Third digit 7? ---> true");
            }
            else
            {
                Console.WriteLine("Third digit 7? ---> false");
            }
        }
    }
}