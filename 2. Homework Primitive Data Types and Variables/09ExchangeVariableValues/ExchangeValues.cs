using System;
//Declare two integer variables a and b and assign them with 5 and 10 and 
//after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine(" a = " + a);
        Console.WriteLine(" b = " + b);

        int x = a;
        a = b;
        b = x;

        Console.WriteLine("After exchanging values:\n a = {0}\n b = {1}",a, b);
    }
}