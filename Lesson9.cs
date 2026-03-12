using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public static class Lesson9
    {
        public static void RunLesson9()
        {
            short[,] nums = {
                { 6, 3, 8 },
                { 4, 8, 4 }
            };

            foreach (short el in nums)
            {
                Console.WriteLine("El:" + el);
            }
            List<int> numbers = new List<int> { 3, 7, 13, 24 };
            numbers.Add(23);
            numbers.Add(1);
            numbers.Remove(24);
            numbers.Sort();
            numbers.Reverse();

            numbers[0] = 7;

            foreach (int n in numbers)
            {
                Console.WriteLine($"El: {n}");
            }

        }
    }
}
