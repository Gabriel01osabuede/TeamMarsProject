namespace week4project
{
    public class Holiday
    {
        public string _name;
        public int _day;
        public string _month;

        public Holiday(string nameOfHoliday,int dayOfMonth,string monthOfHoliday)
        {
            _name = nameOfHoliday.ToUpper();
            _day = dayOfMonth;
            _month = monthOfHoliday.ToUpper();
        }
        public Holiday()
        {

        }
    }
}