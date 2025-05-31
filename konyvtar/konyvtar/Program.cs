using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Konyvtar
{
    public struct Konyv
    {
        public int id, datum;
        public string cim, iro;
        public bool kikerve;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var konyvek = fileBeolvas("konyvek.csv");
            if (konyvek == null)
            {
                Console.WriteLine("Nem sikerült beolvasni a könyvek listáját. A program bezár.");
                Console.ReadLine();
                return;
            }
            while (true)
            {
                Console.Clear();
                kiIr(konyvek);

                Console.WriteLine("\nÍrd be a könyv ID-jét hogy átváltsd a kikért státuszát (vagy 'exit' hogy kilépj a programból)");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                if (int.TryParse(input, out int konyvId))
                {
                    kikerveToggle(konyvek, konyvId);
                }
                else
                {
                    Console.WriteLine("Rossz input, Nyomd meg az Enter-t a folytatáshoz...");
                    Console.ReadLine();
                }
            }
        }
        public static List<Konyv> fileBeolvas(string filename)
        {
            List<Konyv> konyvek = new List<Konyv>();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        string[] parts = sor.Split(',');
                        Konyv ujKonyv = new Konyv();
                        ujKonyv.id = int.Parse(parts[0]);
                        ujKonyv.cim = parts[1];
                        ujKonyv.iro = parts[2];
                        ujKonyv.datum = int.Parse(parts[3]);
                        ujKonyv.kikerve = bool.Parse(parts[4]);
                        konyvek.Add(ujKonyv);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba a file beolvasás közben: {e.Message}");
                return null;
            }
            return konyvek;
        }
        public static void kiIr(List<Konyv> konyvek)
        {
            foreach (var konyv in konyvek)
            {
                Console.WriteLine($"{konyv.id} | {konyv.cim} | {konyv.iro} | {konyv.datum} | {(konyv.kikerve)}");
            }
        }

        public static void kikerveToggle(List<Konyv> konyvek, int id)
        {
            bool found = false;
            for (int i = 0; i < konyvek.Count; i++)
            {
                if (konyvek[i].id == id)
                {
                    Konyv b = konyvek[i];
                    b.kikerve = !b.kikerve;
                    konyvek[i] = b;

                    fileMent(konyvek, "konyvek.csv");

                    if (b.kikerve)
                    {
                        Console.WriteLine($"\nA(z) '{b.cim}' könyv ki lett kérve.");
                    }
                    else
                    {
                        Console.WriteLine($"\nA(z) '{b.cim}' könyv vissza lett hozva.");
                    }
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("\nKönyv ID nem található...");
            }

            Console.WriteLine("Nyomd meg az Enter-t a folytatáshoz...");
            Console.ReadLine();
        }

        public static void fileMent(List<Konyv> konyvek, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var konyv in konyvek)
                {
                    sw.WriteLine($"{konyv.id},{konyv.cim},{konyv.iro},{konyv.datum},{konyv.kikerve.ToString().ToLower()}");
                }
            }
        }
    }

}
