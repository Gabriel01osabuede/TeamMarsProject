using System;
using System.Collections.Generic;

namespace TeamMarsProject
{
      class Holiday
    {
        public string _name;
        public int _day;
        public string _month;

        public Holiday(string nameOfHoliday,int dayOfMonth,string monthOfHoliday)
        {
            _name = nameOfHoliday.ToUpper();
            _day = dayOfMonth;
            _month = monthOfHoliday.ToUpper();
        }

         public static bool inSameMonth(string Holiday1, string Holiday2)
        {
           
            if(Holiday1 == Holiday2)
            {
                return true;
            }
            return false;
        }
        public static List<Holiday> avgDate(List<Holiday> holidays)
        {
            int count = 0;
            int totalHolidayDays = 0;
            
            foreach (var holidayDay in holidays)
            {
                count++;
                totalHolidayDays += holidayDay._day;
            }
            double average = totalHolidayDays / count;
            Console.WriteLine(average);
            return holidays;

        }
    }
}
