using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public static class Lesson10
    {
        public static void RunLesson10(string word)
        {
            Console.WriteLine(word);
        }
        public static int RunLesson10_1(int a, int b)
        {
            int res = a + b;
            return res;
            //RunLesson10(res.ToString());
        }
        public static void RunLesson10_2()
        {
            byte[] nums1 = { 5, 41, 9};
            int summa1 = Summa(nums1);
            byte[] nums2 = { 3, 5, 7, 91 };
            int summa2 = Summa(nums2);

            if (summa1 > summa2)
                Console.WriteLine($"Max: {summa1}");
            else Console.WriteLine($"Max: {summa2}");
        }
        public static int Summa(byte[] digits)
        {
            int summa = 0;
            foreach (byte el in digits)
            {
                summa += el;
            }
            Console.WriteLine($"Result: {summa}");
            return summa;
        }
    }
}
