using System;
/*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter floating-point number: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter floating-pointn umber: ");
        float c = float.Parse(Console.ReadLine());
        string aHex = a.ToString("X");
        string aBinary = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("{0,-10}|{1,-10}|{2,10:0.00}|{3,-10:0.000}|", aHex, aBinary, b, c);
    }
}
