using System;
using System.IO;

namespace Learning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Для перевірки завдання приберіть коментар з потрібного номеру уроку

            //Lesson3.RunLesson3();

            //Lesson4.RunLesson4();

            //Lesson5.RunLesson5();

            //Lesson5.RunLesson52();

            //Lesson6.RunLesson6();

            //Lesson7.RunLesson7();

            //Lesson8.RunLesson8();

            //Lesson9.RunLesson9();

            /*Lesson10.RunLesson10("Повтор методiв");
            string words = "Summ:";
            Lesson10.RunLesson10(words);
            int result = Lesson10.RunLesson10_1(3, 7);
            Lesson10.RunLesson10(result.ToString());*/

            //Lesson10.RunLesson10_2();

            //Lesson11.RunLesson11();

            //Lesson12.RunLesson12();

            Lesson14 bot = new Lesson14();
            bot.setValues("Bot", 3, new byte[] { 0, 0, 0 });

            Lesson14 killer = new Lesson14();
            killer.setValues("Killer", 7, new byte[] { 0, 1, 0 });

            bot.printValues();
            killer.printValues();
        }
    }
}