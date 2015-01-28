using System;
/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/
class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n\n 1 -- >> int \n 2 -- >> double \n 3 -- >> string");
        Console.WriteLine();
        int choice = 0;
        while (choice > 3 || choice < 1)
        {
            Console.Write("Enter your choice: ");
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Wrong input!");
                Console.Write("Enter your choice: ");
            }
            if (choice > 3 || choice < 1)
            {
                Console.WriteLine("Wrong input!");
            }
        }
        Console.WriteLine();
        switch (choice)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int result;
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.Write("Please enter a valid integer: ");
                }
                Console.WriteLine();
                Console.WriteLine(" result: {0}", result + 1);
                break;
            case 2:
                Console.Write("Please enter a doble: ");
                double resultDouble;
                while (!Double.TryParse(Console.ReadLine(), out resultDouble))
                {
                    Console.Write("Please enter a valid double: ");
                }
                Console.WriteLine();
                Console.WriteLine(" result: {0}", resultDouble + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine() + "*";
                Console.WriteLine();
                Console.WriteLine(" result: {0}", str);
                break;
            default:
                break;
        }
        Console.WriteLine();
    }
}