using System;
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
class NullValues
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("{0} {1}", i, d);
        i = 5;
        d = null;
        Console.WriteLine(i + d);
        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine("d = {1} \ni = {0}", i, d);
    }
}   