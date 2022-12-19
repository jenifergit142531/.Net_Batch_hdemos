using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class DateTimeAPI
    {
        public static void DateTimeInfo()
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(2022, 12, 13, 2, 30, 45);
            TimeSpan totalHoursSpent = dt2 - dt1;
            Console.WriteLine("Hours Spent on the hospital :" + Math.Round(totalHoursSpent.TotalHours,2));

            TimeSpan ts = new TimeSpan(2, 12, 34, 48);
           // DateTime dt1=dt + ts;
            Console.WriteLine("New date :" + dt1);
           // Console.WriteLine(dt.ToString());
            Console.WriteLine("Today :"+DateTime.Now.ToString());
            Console.WriteLine("Minimum date value :"+DateTime.MinValue.ToString());
            Console.WriteLine("Maximum date value :"+DateTime.MaxValue.ToString());
            //Console.WriteLine("Date :"+DateOnly.FromDateTime(dt));

        }
    }
}
