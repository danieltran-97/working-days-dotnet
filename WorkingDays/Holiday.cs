using System;

namespace WorkingDays
{
    public class Holiday
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Jurisdiction { get; set; }
        public string IsWeekEnd { get; set; }
        
        public string PublicHolidayFallsOn()
        {
            switch (IsWeekEnd)
            {
                case "Before":
                    return "falls before the weekend";
                case "After":
                    return "falls after the weekend";
                case "None":
                    return "falls on the weekend";
                default:
                    return "";
            }
        }
        
    }
}