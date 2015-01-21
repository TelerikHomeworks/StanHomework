using System;
//Write an expression that checks if given integer is odd or even.
class OddOrNot
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Integer is odd? ---> ");
        Console.WriteLine((number % 2 == 0) ? "false" : "true");
    }
}