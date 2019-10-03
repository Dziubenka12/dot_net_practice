using System;

namespace lecture6
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyArray();
            MaxNumber();
        }
        static void EmptyArray()
        {
            string[] array = new string[] { };
        }
        static void MaxNumber()
        {
            int max = 0;
            int[] randArr = new int[13];
            Random rand = new Random();
            for (int i = 0; i < randArr.Length; i++)
            {
                randArr[i] = rand.Next(100);
                Console.WriteLine(randArr[i]);
                if(max < randArr[i]) { max = randArr[i]; }
            }
            Console.WriteLine($"Максимальное число {max}");
        }
    }
}
