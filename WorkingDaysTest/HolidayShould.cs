using WorkingDays;
using Xunit;

namespace WorkingDaysTest
{
    public class HolidayShould
    {
        [Theory]
        [InlineData("Before","falls before the weekend")]
        [InlineData("After","falls after the weekend")]
        [InlineData("None","falls on the weekend")]
        public void PublicHolidayChecker_should_return_correct_output(string input, string expected)
        {
            var holiday = new Holiday {IsWeekEnd = input};

            var actual = holiday.PublicHolidayFallsOn();
            
            Assert.Equal(expected, actual);
        }
    }
}