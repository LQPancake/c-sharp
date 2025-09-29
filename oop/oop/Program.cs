using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dog bodri = new Dog();
            Dog ubul = new Dog();
            bodri.Name = "Bodri";
            ubul.Name = "Ubul";
            bodri.Age = 10;
            ubul.Age = 2;
            Console.WriteLine($"{bodri.Name} kutya {bodri.Age} éves");
            Console.WriteLine($"{ubul.Name} kutya {ubul.Age} éves");
            bodri.Bark();
            ubul.Drink();
            */
            Car Audi = new Car();
            Audi.Brand = "Audi";
            Audi.Plate = "ABC-123";
            Audi.Year = 2000;
            Audi.Speed = 200;
            Audi.fuelConsumption = 8.5;
            Console.WriteLine(Audi.DistanceConsumption(100));
            Console.WriteLine($"Márka: {Audi.Brand}; Rendszám: {Audi.Plate}; Év: {Audi.Year}; Sebesség: {Audi.Speed}; Fogyasztás: {Audi.fuelConsumption}");
            Console.ReadKey();
        }
    }

    internal class Dog
    {
        public string Name;
        public int Age;
        public void Bark()
        {
            Console.WriteLine($"{Name}: Vau Vau Vau");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name}: Nom Nom Nom");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name}: Zzz Zzz Zzz");
        }
        public void Drink()
        {
            Console.WriteLine($"{Name}: Schlop Schlop Schlop");
        }
    }
    internal class Car
    {
        public string Brand, Plate;
        public int Year, Speed;
        public double fuelConsumption;
        public double DistanceConsumption(int distance)
        {
            return (double)((fuelConsumption / distance) * distance);
        }
    }
}
