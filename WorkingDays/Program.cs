using System;

namespace WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayChecker = new DayChecker();
            var dateInput = GetDecimalFromConsole("Please enter a 2021 date in mm/dd/yyyy format:  ");
            var stateInput = GetStringFromConsole("Please enter a state in abbreviated form:  ");

            dayChecker.CheckWorkingDay(dateInput, stateInput);
        }
        
        static DateTime GetDecimalFromConsole(string input)
        {
            var success = false;
            var result = new DateTime();
            while (!success)
            {
                Console.Write(input);
                var temp = Console.ReadLine();
                success = DateTime.TryParse(temp, out result);
            }
            return result;
        }
        
        private static string GetStringFromConsole(string input)
        {
            var success = false;
            var result = string.Empty;

            while (!success)
            {
                Console.Write(input);
                result = Console.ReadLine();
                success = result is "nsw" or "vic" or "qld" or "sa" or "wa" or "tas" or "nt" or "act";
                
                if (!success)
                {
                    Console.WriteLine("Please enter valid state");
                }
            }

            return result;
        }
    }
}