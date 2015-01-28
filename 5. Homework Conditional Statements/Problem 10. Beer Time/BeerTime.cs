using System;
/*A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59]
 and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
 * Note: You may need to learn how to parse dates and times.*/
class BeerTime
{
    static void Main()
    {
        Console.Write("Enter a time in format \"hh:mm tt\": ");
        DateTime time;
        while (!DateTime.TryParse(Console.ReadLine(), out time))
        {
            Console.Write("Invalid time format. Please enter a time in format \"hh:mm tt\": ");
        }
        DateTime start = DateTime.Parse("1:00 PM");
        DateTime end = DateTime.Parse("3:00 AM");
        if (time >= start || time < end)
        {
            Console.WriteLine("BEEEEEEER TIMEE!!!");
        }
        else
        {
            Console.WriteLine("Non-beer time :(");
        }
    }
}

