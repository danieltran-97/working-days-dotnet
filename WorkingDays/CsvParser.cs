using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkingDays
{
    public class CsvParser
    {
        public List<Holiday> ParseHolidaysCsv()
        {
            var holidays = new List<Holiday>();
            var csvFile = "/Users/danieltran/C# Projects/working-days-dotnet/WorkingDays/csv/australian_public_holidays_2021.csv";
            var reader = new StreamReader(csvFile);
            
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
                    var values = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    date.Add(values[0]);
                    name.Add(values[1]);
                    information.Add(values[2]);
                    jurisdiction.Add(values[3]);
                    isWeekEnd.Add(values[4]);
                }

                for (var i = 1; i < date.Count; i++)
                {
                    var holiday = new Holiday();
                    
                    holiday.Date = DateTime.ParseExact(date[i], "yyyyMMdd", CultureInfo.InvariantCulture);
                    holiday.Name = name[i];
                    holiday.Information = information[i];
                    holiday.Jurisdiction = jurisdiction[i];
                    holiday.IsWeekEnd = isWeekEnd[i];
                    
                    holidays.Add(holiday);
                }
            }
            return holidays;
        }
    }
}