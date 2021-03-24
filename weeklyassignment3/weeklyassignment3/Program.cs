using System;

namespace weeklyassignment3
{
    class Program
    {
        enum weekdays
        {
            monday,
            thursday,
            wendsday,
            thuseday,
            friday,
            saturday,
            sunday,
            today,
        }

        static void Main(string[] args)
        {

            weekdays days = weekdays.monday;

            #region dayofweeks
            switch (days)
            {
                case weekdays.monday:
                    Console.WriteLine("monday");
                    break;
                case weekdays.thursday:
                    Console.WriteLine("thursday");
                    break;
                case weekdays.wendsday:
                    Console.WriteLine("wendsday");
                    break;
                case weekdays.thuseday:
                    Console.WriteLine("thuseday");
                    break;
                case weekdays.friday:
                    Console.WriteLine("friday");
                    break;
                case weekdays.saturday:
                    Console.WriteLine("saturday");
                    break;
                case weekdays.sunday:
                    Console.WriteLine("sunday");
                    break;
            }

            #endregion

        }
    }
}
