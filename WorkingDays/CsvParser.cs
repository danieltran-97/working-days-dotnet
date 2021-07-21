using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkingDays
{
    public static class CsvParser
    {
        private const string File = "australian_public_holidays_2021.csv";
        
        public static List<Holiday> ParseHolidaysCsv()
        {
            var holidays = new List<Holiday>();
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"csv/", File);
            var reader = new StreamReader(path);
            
            using (reader)
            {
                var date = new List<string>();
                var name = new List<string>();
                var information = new List<string>();
                var jurisdiction = new List<string>();
                var isWeekEnd = new List<string>();
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = SplitCommasOutsideQuotes(line);

                    date.Add(values[0]);
                    name.Add(values[1]);
                    information.Add(values[2]);
                    jurisdiction.Add(values[3]);
                    isWeekEnd.Add(values[4]);
                }
                
                for (var i = 1; i < date.Count; i++)
                {
                    holidays.Add(new Holiday
                    {
                        Date = DateTime.ParseExact(date[i], "yyyyMMdd", CultureInfo.InvariantCulture),
                        Name = name[i],
                        Information = information[i].Replace("\"", ""),
                        Jurisdiction = jurisdiction[i],
                        IsWeekEnd = isWeekEnd[i]
                    });
                }
            }
            return holidays;
        }

        private static string[] SplitCommasOutsideQuotes(string line)
        {
            return Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
        }
    }
}