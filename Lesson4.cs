using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Learning
{
    public static class Lesson4
    {
        public static void RunLesson4()
        {
            float user_input;
            Console.Write("Enter number (radius):");
            float radius = float.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
           // float result;
          //  result = user_input + 10f;
            /* result = user_input - 10f;
             result = user_input * 10f;
             result = user_input / 10f;
             result = user_input % 10f;*/
           /* result += 5f;
            result++;
            result--;*/
            Console.WriteLine($"Result: {area}");
            Console.WriteLine("Result: " + Math.Round(2.434f));

        }
    }
}
