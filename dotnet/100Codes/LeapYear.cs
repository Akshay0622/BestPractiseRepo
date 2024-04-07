namespace _100Codes
{
    internal class LeapYear
    {

        static void Main(string[] args)
        {

            int year = 2020;

            if (year % 400 == 00)
            {
                Console.WriteLine("this year is leap year");
            }
            else if (year % 4 == 0 & year % 100 != 0)
            {
                Console.WriteLine("this year is leap year");
            }
            else
            {
                Console.WriteLine("this year is not leap year");
            }


        }
    }
}