using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace burkoloConsole
{
    internal class Helyiseg
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Length { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        private static List<Helyiseg> placeList = new List<Helyiseg>();
        public static int Count { get; private set; } = 0;
        public static double FullPerimeter { get; private set; } = 0;
        public static double FullArea { get; private set; } = 0;
        public Helyiseg(string line)
        {
            string[] items = line.Split(';');
            this.Name = items[0];
            this.Description = items[1];
            this.Length = double.Parse(items[2]);
            this.Width = double.Parse(items[3]);
            if (items.Length > 4)
            {
                this.Height = double.Parse(items[4]);
            }
            else
            {
                this.Height = 2.7;
            }
            Count++;
            FullArea += this.Length * this.Width;
            FullPerimeter += Perimeter();
        }
        public Helyiseg(string roomName, string roomDesc, double roomLength, double roomWidth)
        {
            this.Name = roomName;
            this.Description = roomDesc;
            this.Length = roomLength;
            this.Width = roomWidth;
            Count++;
            FullArea += Length * Width;
            FullPerimeter += 2 * Length + 2 * Width;
        }
        public Helyiseg(string roomName, string roomDesc, double roomLength, double roomWidth, double roomHeight) : this(roomName, roomDesc, roomLength, roomWidth)
        {
            this.Height = roomHeight;
        }
        public double Perimeter()
        {
            return 2 * this.Length + this.Width;
        }
        public double Area()
        {
            return this.Length * this.Width;
        }
        public double NeedsToBePaintWall()
        {
            return 2*this.Width*this.Height + 2*this.Length*this.Height;
        }
        public double CeilingArea()
        {
            return this.Length * this.Width;
        }
        public static double AreaStatic(double a, double b)
        {
            return a + b;
        }
        public static void saveFile(string filename, List<Helyiseg> placeList)
        {
            try
            {
                StreamWriter sw = new StreamWriter("places.csv");
                foreach (var item in placeList)
                {
                    sw.WriteLine($"{item.Name};{item.Description};{item.Length};{item.Width};{item.Height}");
                }
                sw.Close();
                Console.WriteLine("Fileba lementve.");
            }
            catch (Exception ex)
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
                    if (parts.Length == 4)
                    {
                        var newObj = new Helyiseg(parts[0], parts[1], double.Parse(parts[2]), double.Parse(parts[3]));
                        placeList.Add(newObj);
                    }
                    if (parts.Length == 5)
                    {
                        var newObj = new Helyiseg(parts[0], parts[1], double.Parse(parts[2]), double.Parse(parts[3]), double.Parse(parts[4]));
                        placeList.Add(newObj);
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
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
                Console.Write("Magasság: ");
                double roomHeight = double.Parse(Console.ReadLine());

                Helyiseg szoba = new Helyiseg(roomName, roomDesc, roomLength, roomWidth, roomHeight);
                placeList.Add(szoba);
            }
            return placeList;

        }
        public static List<Helyiseg> readFile2(string filename)
        {
            try
            {
                var sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var newObj = new Helyiseg(line);
                    placeList.Add(newObj);
                }
                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hiba a kettes típusú beolvasás közben.", ex.Message);
            }
            return placeList;
        }
        public static void HelyisegLister(List<Helyiseg> placeList)
        {
            foreach (Helyiseg h in placeList)
            {
                Console.WriteLine($"{h.Name} terület: {h.Area()}m\u00B2, kerület: {h.Perimeter()}m");
            }
            Console.WriteLine($"Helyiségek száma: {Helyiseg.Count} db");
            Console.WriteLine($"A szobák összterülete: {Helyiseg.FullArea} m\u00B2");
            Console.WriteLine($"A szobák összkerülete: {Helyiseg.FullPerimeter} m");
        }
        /*public static void Converter(string filenameIn, string filenameOut)
        {
            try
            {
                placeList = readFile(filenameIn);
                StreamWriter sw = new StreamWriter(filenameOut);
                foreach (var item in placeList)
                {
                    sw.WriteLine($"{item.Name};{item.Description};{item.Length};{item.Width};2,7");
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a file konvertálása során. {ex.Message}");
            }
        }*/
    }
}
