using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Lesson14
    {

        protected string name;
        protected short weight;
        protected byte[] coordinates;
        public static int count = 0;
        public string Name
        {
            get
            {
                return name;
            }
            private set;
        }
        public short Weight
        {
            get
            {
                Console.Write("Result: ");
                return this.weight;
            }
            set
            {
                if (value < 1)
                    weight = 0;
                else
                    this.weight = value; //value вбудоване, передається коли ми встановлюємо самі потім в програмі це в аксесор
            }//i this тут необовязкове

        }
        public int Width { get; set; }

        public Lesson14()
        {
            count++;
        }
        public Lesson14(string _name)
        {
            name = _name;
            count++;
        }
        public Lesson14(string _name, short _weight, byte[] _coordinates)
        {
            setValues(_name, _weight, _coordinates);
            printValues();
            count++;
        }
        public void setValues(string name, short weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }
        public void printValues()
        {
            Console.Write($"{name}, weight: {weight}, coordinates: "); //coordinates масив, тому щоб вивести треба його перебрати
            foreach (byte el in coordinates)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine("");
        }
        public static void Print()
        {
            Console.WriteLine("Count: " + count);
        }
    }
}
//Console.WriteLine(people.Substring(0, people.Length - 3));//обрізаєм 3 останні символи