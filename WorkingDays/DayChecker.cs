using System;
using System.Linq;

namespace WorkingDays
{
    public class DayChecker
    {
        public bool CheckWorkingDay(DateTime date, string state)
        {
            var csvReader = new CsvParser();
            var allHolidays = csvReader.ParseHolidaysCsv();
            var holiday = allHolidays.Where(h => h.Date == date && h.Jurisdiction == state).Select(h => h).ToList();
            var isHoliday = holiday.Count == 1;
            var isWorkingDay = !IsWeekend(date) && !isHoliday;

            if (isHoliday)
            {
                Console.WriteLine($"{date:dddd, dd MMMM yyyy}, is {holiday[0].Name} and {holiday[0].PublicHolidayFallsOn()}.");
            }
            if (isWorkingDay)
            {
                Console.WriteLine($"{date:dddd, dd MMMM yyyy}, is a working day");
            }

            if (!isHoliday && !isWorkingDay)
            {
                Console.WriteLine($"{date:dddd, dd MMMM yyyy}, is the weekend");
            }
            
            return isWorkingDay;
        }

        public bool IsWeekend(DateTime day)
        {
            return (day.DayOfWeek == DayOfWeek.Saturday) || (day.DayOfWeek == DayOfWeek.Sunday);
        }
        
    }
}