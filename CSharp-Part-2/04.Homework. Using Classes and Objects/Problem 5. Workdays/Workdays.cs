using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Workdays
{
    class Workdays
    {
        static int WorkDays(string date)
        {
            int counter = 0;
            DateTime toDate = DateTime.Parse(date);
            DateTime currentDateHours = DateTime.Now;
            var currentDateString = currentDateHours.ToShortDateString();
            DateTime currentDate = Convert.ToDateTime(currentDateString);
            currentDate = currentDate.AddDays(1);
            DateTime[] holidays = new DateTime[15];

            holidays[0] = Convert.ToDateTime("2015/01/01");
            holidays[1] = Convert.ToDateTime("2015/03/02");
            holidays[2] = Convert.ToDateTime("2015/03/03");
            holidays[3] = Convert.ToDateTime("2015/04/10");
            holidays[4] = Convert.ToDateTime("2015/04/11");
            holidays[5] = Convert.ToDateTime("2015/04/12");
            holidays[6] = Convert.ToDateTime("2015/04/13");
            holidays[7] = Convert.ToDateTime("2015/05/01");
            holidays[8] = Convert.ToDateTime("2015/05/06");
            holidays[9] = Convert.ToDateTime("2015/09/21");
            holidays[10] = Convert.ToDateTime("2015/09/22");
            holidays[11] = Convert.ToDateTime("2015/12/24");
            holidays[12] = Convert.ToDateTime("2015/12/25");
            holidays[13] = Convert.ToDateTime("2015/12/26");
            holidays[14] = Convert.ToDateTime("2015/12/31");


            while (currentDate < toDate)
            {
                counter++;
                int index = Array.IndexOf(holidays, currentDate);
                bool isWeekend = ((currentDate.DayOfWeek == DayOfWeek.Saturday) || currentDate.DayOfWeek == DayOfWeek.Sunday);
                if (isWeekend)
                {
                    counter--;
                }
                else if (index != -1)
                {
                    counter--;
                }
                currentDate = currentDate.AddDays(1);
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the date you want to learn number of workdays from now: ");
            string date = Console.ReadLine();
            Console.WriteLine(WorkDays(date));
        }
    }
}