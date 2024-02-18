namespace Birth
{
    class Program
    {
        static void Main()
        {
            BirthDate birthDate = new BirthDate(new DateTime(2000, 02, 20));
            Console.WriteLine(birthDate.GetDayUntilBirthDay());
        }

        struct BirthDate
        {
            private DateTime date;

            public BirthDate(DateTime date)
            {
                this.date = date;
            }

            public string GetWeekDayOfBirth()
            {
                return date.ToString("dddd");
            }
            public string GetWeekDayOfBirthInYear(int year)
            {
                DateTime date2 = new DateTime(year, date.Month, date.Day);
                return date2.ToString("dddd");
            }
            public int GetDayUntilBirthDay()
            {
                DateTime today = DateTime.Today;
                DateTime nextBirth = new DateTime(today.Year, date.Month, date.Day);
                if (nextBirth < today)
                {
                    nextBirth = nextBirth.AddYears(1);
                }
                return (nextBirth - today).Days;
            }
        }
    }
}
