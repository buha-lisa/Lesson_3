namespace cs3
{
    struct Data
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }
        public Data(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public void ShowData()
        {
            Console.WriteLine($"Birthday: {Day}.{Month}.{Year}");
        }
    }
}
