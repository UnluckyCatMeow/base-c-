using System;
using System.IO;
using System.Collections.Generic;

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

            /* Lesson14 bot = new Lesson14("Bot", 3, new byte[] { 0, 0, 0 });
             Lesson14 killer = new Lesson14("Killer", 7, new byte[] { 0, 1, 0 });
             Lesson14 robot2 = new Lesson14("Alex");
             //Lesson14.count = 10;
             Lesson14.Print();
             bot.Weight = 10;*/

            /*Lesson14 bots = new Lesson14();
            bots.Weight = -5;
            Console.Write(bots.Weight);
            bots.Width = 10;
            Console.WriteLine($"\nWidth {bots.Width}");*/

            Lesson14 bot = new Lesson14("Bot");
            Lesson17 killer = new Lesson17("Killer", 3, new byte[] {0, 0, 0}, 10);
            //killer.printValues();

            /* Lesson14[] robots = new Lesson14[]
             {
                 bot, killer, new Lesson14()    //нижче приклад як зробить так само
             };*/
            List<Lesson14> robots = new List<Lesson14>();
            robots.Add(bot);
            robots.Add(killer);
            robots.Add(new Lesson14("Alex"));

            Lesson17 killer1 = null;
            foreach (Lesson14 el in robots)
            {
                if (el.Name == "Killer")
                {
                    killer1 = el as Lesson17;
                    killer1.Lazer();
                }
                Console.WriteLine(el is Lesson17);
            }
        }
    }
}