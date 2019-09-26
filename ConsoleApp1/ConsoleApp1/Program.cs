using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now.TimeOfDay;
            if (today.Hours > 9 && today.Hours < 12)
            {
                Console.WriteLine($"Good morning, guys {today}");
            }
            else if (today.Hours > 12 && today.Hours < 15)
            {
                Console.WriteLine($"Good day, guys {today}");
            }
            Console.ReadKey();
        }
    }
}
