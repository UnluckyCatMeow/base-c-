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

        private string name;
        private short weight;
        private byte[] coordinates;
        public void setValues(string _name, short _weight, byte[] _coordinates)
        {
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }
        public void printValues()
        {
            Console.WriteLine($"{name}, weight: {weight}, coordinates: "); //coordinates масив, тому щоб вивести треба його перебрати
            foreach (byte el in coordinates)
            {
                Console.Write($"{el} - ");
            }
            Console.WriteLine("");
        }
    }
}
