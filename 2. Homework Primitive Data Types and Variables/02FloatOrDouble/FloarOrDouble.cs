using System;
//Which of the following values can be assigned to a variable of type float and which 
// to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
class FloarOrDouble
{
    static void Main()
    {
        double firstNumber = 34.567839023;
        Console.WriteLine("Print 34.567839023 (double) ---> {0}\n", firstNumber);

        float secondNumber = 12.345f;
        Console.WriteLine("Print 12.345 (float) ---> {0}\n", secondNumber);

        double thirdNumber = 8923.1234857;
        Console.WriteLine("Print 8923.1234857 (double) ---> {0}\n", thirdNumber);

        float fourthNumber = 3456.091f;
        Console.WriteLine("Print 3456.091 (float) ---> {0}\n", fourthNumber);

    }
}

