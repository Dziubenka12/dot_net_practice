using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
            array[2] *= 10;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }
    }
}
