using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace Learning
{
    public static class Lesson11
    {
        public static void RunLesson11()
        {
            string word = "Hello! ";
            word += "Illia";
            //word = String.Concat(word, "!!");

            char[] words = { 'h', 'i' };

            Console.WriteLine(String.Compare(word, "Llo"));
            Console.WriteLine("----------------------");

            string people = "Alex,Bob,Josh";
            string[] names = people.Split(','); //розбиваємо рядок по символам, в даному випадку кома
            foreach (string el in names)
            {
                Console.WriteLine(el);
            }
            people = String.Join(" | ", names); //об'єднуємо елементи
            Console.WriteLine(people.Trim()); //видалити всі пробіли
            Console.WriteLine(people.ToUpper());//верхній регістр
            Console.WriteLine(people.ToLower()); //Все в нижньому регістрі
            Console.WriteLine(people.Substring(3)); //Обрізати до певної к-сті символів
            Console.WriteLine(people.Substring(0, people.Length - 3));//обрізаєм 3 останні символи
            Console.WriteLine("----------------------");

            /*Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                stream.Write(array);
            }*/
            using (FileStream stream = File.OpenRead("info.txt"))
            {
                byte[] array = new byte[stream.Length];
                stream.Read(array);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);
            }
        }
    }
}
