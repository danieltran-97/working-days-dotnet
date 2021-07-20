using System;
using WorkingDays;
using Xunit;

namespace WorkingDaysTest
{
    public class DayCheckerShould
    {

        [Fact]
        public void CheckWorkingDay_returns_true_when_working_day()
        {
            var dayChecker = new DayChecker();

            var actual = dayChecker.CheckWorkingDay(new DateTime(2021,7,20),"act");
            
            Assert.True(actual);
        }
        [Fact]
        public void CheckWorkingDay_returns_false_when_weekend_day()
        {
            var dayChecker = new DayChecker();

            var actual = dayChecker.CheckWorkingDay(new DateTime(2021,7,25),"act");
            
            Assert.False(actual);
        }
        
        [Fact]
        public void CheckWorkingDay_returns_false_when_public_holiday()
        {
            var dayChecker = new DayChecker();

            var actual = dayChecker.CheckWorkingDay(new DateTime(2021,1,1),"act");
            
            Assert.False(actual);
        }
        
        [Fact]
        public void IsWeekend_returns_true_when_weekend_day()
        {
            var dayChecker = new DayChecker();

            var actual = dayChecker.IsWeekend(new DateTime(2021,7,25));
            
            Assert.True(actual);
        }
        
        [Fact]
        public void IsWeekend_returns_false_when_working_day()
        {
            var dayChecker = new DayChecker();

            var actual = dayChecker.IsWeekend(new DateTime(2021,7,20));
            
            Assert.False(actual);
        }
    }
}