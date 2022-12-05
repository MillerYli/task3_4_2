using System;

namespace Name
{
    class Programm
    {
        public static void Main(string[] args)
        {
            DaysOfWeek MyFaforiteDay;

            MyFaforiteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFaforiteDay);

        }
    }
    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
}

