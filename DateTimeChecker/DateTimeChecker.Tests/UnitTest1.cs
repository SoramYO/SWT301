
namespace DateTimeChecker.Tests
{
    [TestFixture]
    public class DateTimeCheckerTests
    {
        [TestCase(1, 1, 2023, ExpectedResult = true)]
        [TestCase(31, 1, 2023, ExpectedResult = true)]
        [TestCase(29, 2, 2020, ExpectedResult = true)]
        [TestCase(29, 2, 2021, ExpectedResult = false)]
        [TestCase(30, 4, 2023, ExpectedResult = true)]
        [TestCase(31, 4, 2023, ExpectedResult = false)]
        public bool DayInMonth_ValidatesCorrectly(int day, int month, int year)
        {
            return IsValidDate(day, month, year);
        }

        private bool IsValidDate(int day, int month, int year)
        {
            if (month < 1 || month > 12 || day < 1)
            {
                return false;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year))
            {
                daysInMonth[1] = 29;
            }

            return day <= daysInMonth[month - 1];
        }

        private bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}