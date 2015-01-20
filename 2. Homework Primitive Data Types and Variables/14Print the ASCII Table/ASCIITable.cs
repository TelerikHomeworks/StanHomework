using System;
using System.Text;
//Problem 14.* Print the ASCII Table
//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
class PrintASCII
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i <= 255; i++)
        {
            if (i >= 127 && i <= 160)
            {
                System.Console.WriteLine("{0} = :)", i);
            }
            else
            {
                System.Console.WriteLine("{0} = {1}", i, (char)i);
            }

        }
    }
}
