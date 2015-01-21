using System;
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
    class MoonGravity
    {
        static void Main()
        {
            Console.Write("Enter your weight: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the Moon is ---> " +  weight*0.17f);
        }
    }