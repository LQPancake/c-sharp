using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog bodri = new Dog();
            bodri.Name = "Bodri";
            bodri.Age = 10;
            Dog ubul = new Dog();
            ubul.Name = "Ubul";
            ubul.Age = 20;
        }
    }

    internal class Dog
    {
        public string Name;
        public int Age;
    }
}