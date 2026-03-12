using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public static class Lesson8
    {
        public static void RunLesson8()
        {
            byte[] nums = new byte[5];
            nums[0] = 1;
            nums[1] = 3;
            nums[2] = 6;
            nums[3] = 8;
            nums[4] = 3;

            nums[3] += 16;
            Console.WriteLine($"{nums[3]}");

            string[] names = new string[] { "Dasha", "Musia", "Marsik" };
            names[0] = "Daria";
            Console.WriteLine(names[0]);

            for (byte i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            for (int e = 0; e < names.Length; e++)
                Console.WriteLine(names[e]);

            Console.WriteLine();

            short[] numbers = new short[10];
            short summa = 0;

            Random random = new Random();
            for (byte u = 0; u < numbers.Length; u++)
            {
                numbers[u] = Convert.ToInt16(random.Next(-23, 23));
                Console.WriteLine($"El: {numbers[u]}");

                summa += numbers[u];
            }
            Console.WriteLine($"Summa: {summa}");

            Console.WriteLine();
            //Багатовимірні масиви
            char[,] symbols = new char[2, 3];
            symbols[0, 0] = 'h';
            Console.WriteLine(symbols[0, 0]);

            int[,] number =
            { 
                {5, 7},
                {8, 9},
                {90, 3}
            };
            Console.WriteLine(number[2, 0]);
        }
    }
}
