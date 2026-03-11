using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public static class Lesson5
    {
        //умовні конструкції
        public static void RunLesson5()
        {
            int user = Convert.ToInt32(Console.ReadLine());
            bool isHasCar = false;
            if (user > 5 && !isHasCar) //&& its "and", || its "or"
            {

                Console.WriteLine("True");

                Console.WriteLine("Number is five+");
            }
            else if (user == 0)
                Console.WriteLine("Number is zero");
            else if (user < 0)
                Console.WriteLine("Number <0");
            else
            {
                Console.WriteLine("Number 1-5");
            }
        }

        public static void RunLesson52()
        {
            Console.Write("Enter login: ");
            string role = Console.ReadLine();

            if (role == "Admin")
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter age: ");
                short age = Convert.ToInt16(Console.ReadLine());

                if(age >0 && age < 110)
                    Console.WriteLine($"User`s age is {age}. User`s name is {name}");
                else
                {
                    Console.WriteLine("error");
                    age = 0;
                }
            } else
                Console.WriteLine($"User`s login is {role}. ");
        }
    }
}

