using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace struktura
{
    public struct Adatok
    {
        public string nev, lakcim, telefonszam;
        public int eletkor;
        public bool tanuloE;
    }
    internal class Program
    {
        static void Main(string[] args)
        {  
            var szemelyAdatok = Adatrogzites();
            filebaIr(szemelyAdatok, "adatok.csv");
        }
        public static List<Adatok> Adatrogzites()
        {
            List<Adatok> szemelyAdatok = new List<Adatok>();
            while (true){
                Console.Write("Név: ");
                string nev = Console.ReadLine();
                if (nev == "") break;
                Console.WriteLine("Lakcím: ");
                string lakcim = Console.ReadLine();
                Console.WriteLine("Telefonszám: ");
                string telefonszam = Console.ReadLine();
                Console.WriteLine("Életkor: ");
                int eletkor = int.Parse(Console.ReadLine());
                Console.WriteLine("Tanuló?(I = Igen; N = Nem) ");
                string tanulo = Console.ReadLine();
                bool tanuloE = false;
                if (tanulo == "I" || tanulo == "i")
                {
                    tanuloE = true;
                }
                Adatok ujAdat = new Adatok();
                ujAdat.nev = nev;
                ujAdat.lakcim = lakcim;
                ujAdat.telefonszam = telefonszam;
                ujAdat.eletkor = eletkor;
                ujAdat.tanuloE = tanuloE;

                szemelyAdatok.Add(ujAdat);
            }
            return szemelyAdatok;
        }
        public static void filebaIr(List<Adatok> adatok, string filenev)
        {
            try{
                StreamWriter sw = new StreamWriter(filenev);
                foreach (var adat in adatok)
                {
                    sw.Write($"" +
                        $"{adat.nev};" +
                        $"{adat.lakcim};" +
                        $"{adat.telefonszam};" +
                        $"{adat.eletkor};" +
                        $"{adat.tanuloE}");

                }
                sw.Close();
            }
            catch{
                Console.WriteLine("Fileba írás közben hiba történt.");
                Console.ReadKey();
            }
        }
    }
}
