using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Lesson17 : Lesson14
    {
        public int Damage { get; private set; }
        public Lesson17() { }
        public Lesson17(string _name, short _weight, byte[] _coordinates, int damage) : base (_name, _weight, _coordinates)
        {
            Damage = damage;
            base.printValues();
        }
        public void Lazer()
        {
            Console.WriteLine("Lazer is shooting");
        }
    }
}
