namespace DateTimeChecker.Tests
{
    [TestFixture]
    public class CheckDateTests
    {
        [TestCase("01/01/2023", ExpectedResult = true)]
        [TestCase("31/01/2023", ExpectedResult = true)]
        [TestCase("29/02/2020", ExpectedResult = true)]
        [TestCase("29/02/2021", ExpectedResult = false)]
        [TestCase("30/04/2023", ExpectedResult = true)]
        [TestCase("31/04/2023", ExpectedResult = false)]
        public bool CheckDate_ValidatesCorrectly(string date)
        {
            var parts = date.Split('/');
            int day = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int year = int.Parse(parts[2]);

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

        private static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}