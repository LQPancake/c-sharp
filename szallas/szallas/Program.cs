using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static szallas.Program;

namespace szallas
{
    internal class Program
    {
        public struct Szallas
        {
            public string nev, cim, uzNev, uzCim, tipus, uzTelSzam;
            public int szobaSzam, agySzam;
            public bool statusz;
        }
        static void Main(string[] args)
        {
            Console.Write("4. feladat:");
            Console.WriteLine("5. feladat:");
            Console.WriteLine("6. feladat:");

            Console.ReadLine();
        }
        public static void beOlvas(string fileName = "szallas2022.csv")
        {
            try
            {
                string[] sorok = File.ReadAllLines(fileName, Encoding.UTF8);
                foreach (var sor in sorok)
                {
                    StreamReader Sr = new StreamReader(fileName, Encoding.UTF8);
                    List<Szallas> szallasok = new List<Szallas>();
                    sor[] = Sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba van a kódban!", ex.Message);
            }
        }
    }

}
