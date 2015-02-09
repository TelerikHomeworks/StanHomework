using System;
//Write a program that reads two integer arrays from the console and compares them element by element.
class CompareArrays
{
    static void Main()
    {
        bool equal = true;
        Console.Write("Enter size of first array: ");
        int sizeOne = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[sizeOne];
        Console.WriteLine("Enter {0} integers for first array each on a single line...", sizeOne);
        for (int i = 0; i < arrayOne.Length; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter size of second array: ");
        int sizeTwo = int.Parse(Console.ReadLine());
        int[] arrayTwo = new int[sizeTwo];
        Console.WriteLine("Enter {0} integers for second array on a singe line...", sizeTwo);
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        if (sizeOne != sizeTwo)
        {
            Console.WriteLine("Arrays are not equal.");
            return;
        }
        else
        {
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    equal = false;
                }
            }
        }
        Console.WriteLine(equal? "Arrays are equal" : "Arrays are not equal");
    }
}