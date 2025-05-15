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
            var szemelyAdatok = Start("adatok.csv");
            Adatrogzites(szemelyAdatok);
            filebaIr(szemelyAdatok, "adatok.csv");
            filebolOlvas("adatok.csv");
            Console.WriteLine($"Adatok száma: {szemelyAdatok.Count()}");
            Console.WriteLine($"Adatok száma saját számításaink szerint: {AdatSzamolo(szemelyAdatok)}");
            Console.WriteLine($"20 éves múlt emberek száma: {FelnottSzamolas(szemelyAdatok)}");
            bekertKor(szemelyAdatok);
            var korDict = korSzamolo(szemelyAdatok);
            DictLista(korDict);

            Console.ReadKey();
        }
        public static void DictLista(SortedDictionary<int, int> lista)
        {
            foreach (var elem in lista)
            {
                Console.WriteLine($"{elem.Key} éves {elem.Value} fő");
            }
        }
        public static Dictionary<int, int> korSzamolo(List<Adatok> adatok)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(var adat in adatok)
            {
                if(dict.ContainsKey(adat.eletkor))
                {
                    dict[adat.eletkor]++;
                }
                else
                {
                    dict.Add(adat.eletkor, 1);
                }
            }
            return dict;
        }
        public static void Adatrogzites(List<Adatok> szemelyAdatok)
        {
            //List<Adatok> szemelyAdatok = new List<Adatok>();
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
        }
        public static void filebaIr(List<Adatok> adatok, string filenev)
        {
            try{
                StreamWriter sw = new StreamWriter(filenev);
                foreach (var adat in adatok)
                {
                    sw.WriteLine($"" +
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
            }
        }
        public static void filebolOlvas(string filenev)
        {
            try
            {
                StreamReader sr = new StreamReader(filenev);
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] sorDb = sor.Split(';');
                    Console.WriteLine("\nADAT:");
                    Console.WriteLine($"" +
                        $"{sorDb[0]}\t" +
                        $"{sorDb[1]}\t" +
                        $"{sorDb[2]}\t" +
                        $"{sorDb[3]}\t" +
                        $"{sorDb[4]}");
                }
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Fileból olvasás közben hiba történt.{e.Message}");
                Console.ReadKey();
            }
        }
        public static List<Adatok> Start(string filenev)
        {
            List<Adatok> szemelyAdatok = new List<Adatok>();
            try
            {
                StreamReader sr = new StreamReader(filenev);
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] sorDb = sor.Split(';');
                    Adatok ujAdat = new Adatok();
                    ujAdat.nev = sorDb[0];
                    ujAdat.lakcim = sorDb[1];
                    ujAdat.telefonszam = sorDb[2];
                    ujAdat.eletkor = int.Parse(sorDb[3]);
                    ujAdat.tanuloE = bool.Parse(sorDb[4]);
                    szemelyAdatok.Add(ujAdat);
                }

                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Hiba történt a file beolvasás közben.{e.Message}");
            }

            return szemelyAdatok;
        }
        public static int AdatSzamolo(List<Adatok> adatokList)
        {
            int szamlalo = 0;
            foreach(var adatok in adatokList)
            {
                szamlalo++;
            }
            return szamlalo;
        }
        public static int FelnottSzamolas(List<Adatok> adatokList)
        {
            int korSzamlalo = 0;
            foreach(var adat in adatokList)

            {
                if (adat.eletkor >= 20)
                {
                    korSzamlalo++;
                }
            }
            return korSzamlalo;
        }
        public static void bekertKor(List<Adatok> adatokList)
        {
            Console.WriteLine("Adj meg egy kort: ");
            int bekertKor = int.Parse(Console.ReadLine());
            foreach(var adatok in adatokList)
            {
                if(adatok.eletkor >= bekertKor)
                {
                    Console.Write($"{adatok.nev}");
                }
            }
        }
    }
}
