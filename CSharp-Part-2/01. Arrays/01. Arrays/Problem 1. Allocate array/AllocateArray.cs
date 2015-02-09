using System;
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
class Program
{
    static void Main()
    {
        int[] integersMultipliedByFive = new int[20];
        for (int i = 0; i < integersMultipliedByFive.Length; i++)
        {
            integersMultipliedByFive[i] = i * 5;
            Console.WriteLine("{0} - > {1}", i, integersMultipliedByFive[i]);
        }
    }
}