using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public static class Lesson6
    {
        public static void RunLesson6()
        {
            Console.WriteLine("Enter your favorite number from 1 to 5: ");
            short user_input = Convert.ToInt16(Console.ReadLine());

            switch (user_input)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                    Console.WriteLine("Number is 3");
                    break;
                case 4:
                    Console.WriteLine("Number is 4");
                    break;
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
        }
    }
}
