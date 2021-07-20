using System;
using System.Collections.Generic;
using System.IO;

namespace WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            // var insert = DateTime.ParseExact("20210101", "yyyyMMdd", 
            //     CultureInfo.InvariantCulture);
            //
            // Console.WriteLine(insert);
            // var holidayChecker = new HolidayChecker();
            // holidayChecker.CheckHoliday(new DateTime(2021,1,1),"act");
            var csvParser = new CsvParser();
            
            Console.WriteLine(csvParser.ParseHolidaysCsv()[22].Information);
            var dayChecker = new DayChecker();

            dayChecker.CheckWorkingDay(new DateTime(2021,10,4), "nsw");
        }
    }
}