using System;
using System.Linq;

namespace WorkingDays
{
    public static class DayChecker
    {
        public static bool CheckWorkingDay(DateTime date, string state)
        {
            var allHolidays = CsvParser.ParseHolidaysCsv();
            var holiday = allHolidays.Where(h => h.Date == date && h.Jurisdiction == state).Select(h => h).ToList();
            var isHoliday = holiday.Count == 1;
            var isWorkingDay = !IsWeekend(date) && !isHoliday;

            if (isHoliday)
            {
                Console.WriteLine($"{PrintFullDate(date)}, is {holiday[0].Name} and {holiday[0].PublicHolidayFallsOn()}.");
            }
            if (isWorkingDay)
            {
                Console.WriteLine($"{PrintFullDate(date)}, is a working day");
            }

            if (!isHoliday && !isWorkingDay)
            {
                Console.WriteLine($"{PrintFullDate(date)}, is the weekend");
            }
            
            return isWorkingDay;
        }

        private static bool IsWeekend(DateTime day)
        {
            return day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
        }

        private static string PrintFullDate(DateTime day)
        {
            return $"{day:dddd, dd MMMM yyyy}";
        }

    }
}