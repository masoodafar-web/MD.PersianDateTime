using Xunit;

namespace MD.PersianDateTime.Standard.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetPersianDateOfLastDayOfMonth1()
        {
            var date = new PersianDateTime(1399, 5, 1);
            Assert.Equal(new PersianDateTime(date.Year, date.Month, date.GetMonthDays), date.GetPersianDateOfLastDayOfMonth());
        }

        [Fact]
        public void GetPersianDateOfLastDayOfMonth2()
        {
            var date = new PersianDateTime(1399, 10, 1);
            Assert.Equal(new PersianDateTime(date.Year, date.Month, date.GetMonthDays), date.GetPersianDateOfLastDayOfMonth());
        }

        [Fact]
        public void GetPersianDateOfLastDayOfMonth3()
        {
            var date = new PersianDateTime(1399, 12, 1);
            Assert.Equal(new PersianDateTime(date.Year, date.Month, date.GetMonthDays), date.GetPersianDateOfLastDayOfMonth());
        }
    }
}
