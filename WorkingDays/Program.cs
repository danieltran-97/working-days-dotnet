using System;

namespace WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateInput = GetDecimalFromConsole("Please enter a 2021 date in mm/dd/yyyy format:  ");
            var stateInput = GetStringFromConsole("Please enter a state in abbreviated form:  ");

            DayChecker.CheckWorkingDay(dateInput, stateInput);
        }

        private static DateTime GetDecimalFromConsole(string message)
        {
            var success = false;
            var result = new DateTime();
            while (!success)
            {
                Console.Write(message);
                var temp = Console.ReadLine();
                success = DateTime.TryParse(temp, out result);
                
                if (!success)
                {
                    Console.WriteLine("Please enter valid date");
                }
            }
            return result;
        }
        
        private static string GetStringFromConsole(string message)
        {
            var success = false;
            var result = string.Empty;

            while (!success)
            {
                Console.Write(message);
                result = Console.ReadLine();
                success = result is "nsw" 
                                 or "vic" 
                                 or "qld" 
                                 or "sa" 
                                 or "wa" 
                                 or "tas" 
                                 or "nt" 
                                 or "act";
                
                if (!success)
                {
                    Console.WriteLine("Please enter valid state");
                }
            }
            return result;
        }
    }
}