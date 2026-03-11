using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Learning
{
    public static class Lesson7
    {
        public static void RunLesson7()
        {
            /* for (byte i = 200; i > 50; i-=9)
             {
                 Console.WriteLine($"Element: {i}");
             }*/

            /* int i = 1;
             while (i <= 10)
             {
                 Console.WriteLine($"El.: {i}");
                 i++;
             }*/

            bool isGetUserData = false;
            while (!isGetUserData)
            {
                Console.WriteLine("Am i a good programmer??: ");
                string data = Console.ReadLine();
                if (data.ToLower() == "yes") //не чутлива відповідь до регістру
                    isGetUserData = true;
            }
            Console.WriteLine("Отак от блять!");
            Console.WriteLine("");
            int i = 0;
            do
            {
                Console.WriteLine($"El: {i}");
                i++;
            }
            while (i > 10);

            for (int a = 5; a < 15; a++)
            {
                if (a == 10) break;
                if (a % 2 == 0) continue;
                Console.WriteLine($"El.: {a}");
            }
        }
    }
}
