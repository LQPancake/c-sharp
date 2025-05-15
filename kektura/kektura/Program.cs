using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace kektura
{
    public struct turaAdat
    {
        public string kezdoPont, celPont;
        public int tavHossz, emelkedesek, lejtesek;
        public bool pecsetHely;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var turaAdatok = adatRead("kektura.csv");
            Console.Write("3. feladat: Szakaszok száma:");
            Console.WriteLine("4. feladat: A túra teljes hossza:");
            Console.WriteLine("5. feladat: A legrövidebb szakasz adatai:");
            Console.WriteLine("7. feladat: Hiányos állomásnevek:");
            Console.WriteLine("8. feladat: A túra legmagasabban fekvő végpontja:");
        }
        public static List<turaAdat> adatRead(string filename = "kektura.csv")
        {
            {
                List<turaAdat> turaAdatok = new List<turaAdat>();
                try
                {
                    StreamReader sr = new StreamReader(filename);
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        string[] sorDb = sor.Split(';');
                        turaAdat ujAdat = new turaAdat();
                        ujAdat.kezdoPont = sorDb[0];
                        ujAdat.celPont = sorDb[1];
                        ujAdat.tavHossz = int.Parse(sorDb[2]);
                        ujAdat.emelkedesek = int.Parse(sorDb[3]);
                        ujAdat.lejtesek = int.Parse(sorDb[4]);
                        ujAdat.pecsetHely = bool.Parse(sorDb[5]);
                        turaAdatok.Add(ujAdat);
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Az adatReadben hiba történt! {e.Message}");
                }
                return turaAdatok;
            }
        }
    }
}
