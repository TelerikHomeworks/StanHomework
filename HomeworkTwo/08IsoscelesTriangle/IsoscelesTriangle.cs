using System;
using System.Text;
//Write a program that prints an isosceles triangle of 9 copyright symbols ©
class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(@"
   ©
  © ©
 ©   ©
© © © ©");
    }
}