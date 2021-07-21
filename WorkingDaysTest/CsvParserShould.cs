using WorkingDays;
using Xunit;

namespace WorkingDaysTest
{
    public class CsvParserShould
    {
        [Fact]
        public void ParseHolidaysCsv_should_return_a_list_of_91_holidays()
        {
            var listOfHolidays = CsvParser.ParseHolidaysCsv();
            
            Assert.Equal(91, listOfHolidays.Count);
        }

        [Fact]
        public void ParseHolidaysCsv_returns_information_with_commas()
        {
            var holidayList = CsvParser.ParseHolidaysCsv();
            var actual = holidayList[22].Information;
            var expected =
                "Always on a Monday, creating a long weekend. It celebrates the eight-hour working day, a victory for workers in the mid-late 19th century.";
        
            Assert.Equal(expected, actual);
        }

    }
}