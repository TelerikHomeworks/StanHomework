using System;

class YouAfterTenYears
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now; //calculating today's date
        Console.Write("Write down your Birthday YYYY-MM-DD: ");
        DateTime date = DateTime.Parse(Console.ReadLine()); //read your birthday from console
        Console.WriteLine();
        if (today.Month < date.Month) //check if your birthday has not passed
        {
            Console.WriteLine("Your age now: " + ((today.Year - date.Year) - 1));
            Console.WriteLine("Your age after 10 years: " + (((today.Year - date.Year) - 1) + 10 ));
        }
        else if (today.Month > date.Month) //check if your birthday has passed
        {
            Console.WriteLine("Your age now: " + (today.Year - date.Year));
            Console.WriteLine("Your age after 10 years: " + ((today.Year - date.Year) + 10));
        }
        else //check if current month equals your birthday month
        {
            if (today.Day < date.Day) //check if your birthday has not passed
            {
                Console.WriteLine("Your age now: " + ((today.Year - date.Year) - 1));
                Console.WriteLine("Your age after 10 years: " + (((today.Year - date.Year) - 1) + 10));
            }
            else //check if your birthday has passed
            {
                Console.WriteLine("Your age now: " + (today.Year - date.Year));
                Console.WriteLine("Your age after 10 years: " + ((today.Year - date.Year) + 10));
            }
        }
        Console.ReadLine();
    }
}