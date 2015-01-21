using System;
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
class DivideSevenFive
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number % 5 == 0) && (number % 7 ==0) && (number != 0));
    }
}