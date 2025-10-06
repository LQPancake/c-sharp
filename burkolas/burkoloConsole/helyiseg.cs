using System;
using System.IO;
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
        public static void saveFile(List<Helyiseg> placeList)
        {
            try
            {
                StreamWriter sw = new StreamWriter("places.csv");
                foreach(var item in placeList)
                {
                    sw.WriteLine("{item.roomName};{item.roomDesc};{item.roomLength};{item.roomWidth}");
                }
                sw.Close();
                Console.WriteLine("Fileba lementve.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hiba a fileba írása során. {ex.Message}");
            }
        }
        public static List<Helyiseg> readFile(string filename)
        {
            List<Helyiseg> placeList = new List<Helyiseg>();
            try
            {
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(';');
                    Helyiseg szoba = new Helyiseg();
                    szoba.Name = parts[0];
                    szoba.Description = parts[1];
                    szoba.Length = double.Parse(parts[2]);
                    szoba.Width = double.Parse(parts[3]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hiba történt a file beolvasása során. {ex.Message}");
            }
            return placeList;
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
