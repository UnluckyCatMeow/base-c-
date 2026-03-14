using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public static class Lesson12
    {
        public static void RunLesson12()
        {
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.Write("Enter number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    float result = 100 / num;
                    Console.WriteLine($"100 / {num}, result: {result}");
                    Console.Write("Nice.");
                    isRunning = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yuy entered not a number.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Your number is 0.");
                }
                finally //спрацьовує завжди незалежно від того що саме виконається
                {
                   
                }
            }
        }
    }
}
