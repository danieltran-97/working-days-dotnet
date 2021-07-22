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
            var actual = DayChecker.CheckWorkingDay(new DateTime(2021,7,20),"act");
            
            Assert.True(actual);
        }
        [Fact]
        public void CheckWorkingDay_returns_false_when_weekend_day()
        {
            var actual = DayChecker.CheckWorkingDay(new DateTime(2021,7,25),"nsw");
            
            Assert.False(actual);
        }
        
        [Fact]
        public void CheckWorkingDay_returns_false_when_public_holiday()
        {
            var actual = DayChecker.CheckWorkingDay(new DateTime(2021,1,1),"qld");
            
            Assert.False(actual);
        }
    }
}