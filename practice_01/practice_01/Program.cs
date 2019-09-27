using System;

namespace practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now.TimeOfDay;
            if (today.Hours >= 9 && today.Hours < 12) 
            {
                Console.WriteLine($"Good Morning, guys {today}");
            }
            else if (today.Hours >= 12 && today.Hours < 15)
            {
                Console.WriteLine($"Good day, guys {today}");
            }
            else if (today.Hours >= 15 && today.Hours < 22)
            {
                Console.WriteLine($"Good evening, guys {today}");
            }
            else 
            {
                Console.WriteLine($"Good night, guys {today}");
            }
            Console.ReadKey();
        }
    }
}
