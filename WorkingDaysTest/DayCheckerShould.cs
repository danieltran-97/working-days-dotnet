using System;
using WorkingDays;
using Xunit;

namespace WorkingDaysTest
{
    public class DayCheckerShould
    {

        [Fact]
        public void Test_day_is_a_working_day()
        {
            var dayChecker = new DayChecker();

            var actual = dayChecker.CheckWorkingDay(new DateTime(2021,7,20),"act");
            
            Assert.True(actual);
        }
        [Fact]
        public void Test_day_is_the_weekend()
        {
            var dayChecker = new DayChecker();

            var actual = dayChecker.CheckWorkingDay(new DateTime(2021,7,25),"act");
            
            Assert.False(actual);
        }
        
        [Fact]
        public void Test_day_is_a_public_holiday()
        {
            var dayChecker = new DayChecker();

            var actual = dayChecker.CheckWorkingDay(new DateTime(2021,1,1),"act");
            
            Assert.False(actual);
        }
    }
}