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
            var szallasok = beOlvas();
            Console.WriteLine("Az összes szálláshelyek száma: " + szallasok.Count);
            Console.WriteLine("5. feladat:");
            var aktiv = szallasok.Where(x => x.statusz);
            double atlagAgy = aktiv.Average(x => x.agySzam);
            Console.WriteLine("Átlagos ágyszám (aktív): " + atlagAgy);
            Console.WriteLine("6. feladat:");
            Console.WriteLine("Szeghalom környéki aktív szállások:");
            var szeghalomAktiv = szallasok.Where(x => x.statusz && x.cim.Contains("Szeghalom")); foreach (var sz in szeghalomAktiv)
            {
                Console.WriteLine($"{sz.nev} - {sz.cim}");
            }
            Console.ReadLine();
        }
        public static List<Szallas> beOlvas(string fileName = "szallas2022.csv")
        {
            List<Szallas> szallasok = new List<Szallas>();
            try
            {
                StreamReader sr = new StreamReader(fileName, Encoding.UTF8);
                using (sr)
                {
                    string sor = sr.ReadLine();
                    string[] mezok = sor.Split(';');

                    Szallas sz = new Szallas
                    {
                        nev = mezok[0],
                        cim = mezok[1],
                        szobaSzam = Convert.ToInt32(mezok[2]),
                        agySzam = Convert.ToInt32(mezok[3]),
                        uzNev = mezok[4],
                        uzCim = mezok[5],
                        uzTelSzam = mezok[6],
                        statusz = mezok[7].Trim() == "Aktív",
                        tipus = mezok[8],
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba van a kódban!", ex.Message);
            }
            return szallasok;
        }
    }

}
