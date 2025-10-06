using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burkoloConsole
{
    internal class Helyiseg
    {
        public string Name;
        public string Description;
        public double Length;
        public double Width;
        public int Perimeter()
        {
            return 2 * (int)(Length + Width);
        }
        public double Area()
        {
            return Length * Width;
        }
        public static double AreaStatic(double a, double b)
        {
            return a + b;
        }
        public static List<Helyiseg> DataLoader()
        {
            List<Helyiseg> placeList = new List<Helyiseg>();
            while (true)
            {
                Console.WriteLine("Add meg egy helyiség adatait!");
                Console.Write("Neve: ");
                string roomName = Console.ReadLine();
                if (roomName == "") break;
                Console.Write("Megjegyzés: ");
                string roomDesc = Console.ReadLine();
                Console.Write("Hossz: ");
                double roomLength = double.Parse(Console.ReadLine());
                Console.Write("Szélesség: ");
                double roomWidth = double.Parse(Console.ReadLine());

                Helyiseg szoba = new Helyiseg();
                szoba.Name = roomName;
                szoba.Description = roomDesc;
                szoba.Length = roomLength;
                szoba.Width = roomWidth;
                placeList.Add(szoba);
            }
            return placeList;

        }
    }
}
