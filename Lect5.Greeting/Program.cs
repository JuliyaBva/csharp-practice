using System;


namespace Lect5.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan dt = DateTime.Now.TimeOfDay;
            int hours = dt.Hours;
            if (hours >= 9 && hours < 12)
            {
                Console.WriteLine("Good morning, guys!");
            }
            else if (hours >= 12 && hours < 15)
            {
                Console.WriteLine("Good day, guys!");
            }
            if (hours >= 15 && hours < 22)
            {
                Console.WriteLine("Good evening, guys!");
            }
        }
    }
}
