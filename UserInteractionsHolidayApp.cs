using System;
using System.Collections.Generic;

namespace week4project
{
    class UserInteractionsHolidayApp
    {
         public static List<Holiday> avgDate(List<Holiday> holidays)
        {
            double count = 0;
            double totalHolidayDays = 0;
            
            foreach (var holidayDay in holidays)
            {
                count++;
                totalHolidayDays += holidayDay._day;
            }
            double average = totalHolidayDays / count;
            Menu.PromptUser($"The Average of all the holiday days in d List = {average}");
            Menu.PromptUser("\n================================================\n");
            return holidays;

        }

       

        
    }
}