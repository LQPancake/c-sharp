using System;
using System.IO;
using System.Linq;

namespace lotto_doga
{
    internal class Program
    {
        public static int sorokSzam = 30;
        public static int oszlopokSzam = 6;
        public static int tartomany = 46;
        static void Main(string[] args)
        {
            var tipp = lottoGyar(sorokSzam, oszlopokSzam, tartomany);
            kiIr(tipp);
            filebaIras(tipp, "tippek.csv");
            var ujtipp = filebolOlvasas("tippek.csv");
            kiIr(ujtipp);
            Console.ReadKey();
        }
        public static int[,] lottoGyar(int sorokSzam, int oszlopokSzam, int tartomany)
        {
            int[,] szamok = new int[sorokSzam, oszlopokSzam];
            Random rnd = new Random();
            for (int i = 0; i < sorokSzam; i++)
            {
                int[] sor = new int[oszlopokSzam];
                for (int j = 0; j < oszlopokSzam; j++)
                {
                    int szam = rnd.Next(1, tartomany);
                    while (sor.Contains(szam))
                    {
                        szam = rnd.Next(1, tartomany);
                    }
                    sor[j] = szam;
                }
                Rendez(sor);
                for (int j = 0; j < oszlopokSzam; j++)
                {
                    szamok[i, j] = sor[j];
                }
            }
            return szamok;
        }
        public static void Rendez(int[] sor)
        {
            for (int i = 0; i < sor.Length - 1; i++)
            {
                for (int j = 0; j < sor.Length - 1 - i; j++)
                {
                    if (sor[j] > sor[j + 1])
                    {
                        int seged = sor[j];
                        sor[j] = sor[j + 1];
                        sor[j + 1] = seged;
                    }
                }
            }
        }
        public static void kiIr(int[,] tomb)
        {
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write($"{tomb[i, j]}");
                    if (j == oszlopokSzam-1)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(';');
                    }
                }
            }
            Console.WriteLine();
        }
        public static void filebaIras(int[,] szamok, string filenev)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filenev);
                for (int i = 0; i < szamok.GetLength(0); i++)
                {
                    for (int j = 0; j < szamok.GetLength(1); j++)
                    {
                        sw.Write(szamok[i, j]);
                        if (j == 4)
                        {
                            sw.WriteLine();
                        }
                        else
                        {
                            sw.Write(";");
                        }
                    }
                }
                sw.Close();
            }
            catch
            {
                Console.Write("A fileba írás közben hiba történt.");
                Console.ReadKey();
            }
        }
        public static int[,] filebolOlvasas(string filenev)
        {
            try
            {
                int[,] ujtipp = new int[sorokSzam, oszlopokSzam];
                StreamReader sr = new StreamReader(filenev);
                for (int i = 0; i < ujtipp.GetLength(0); i++)
                {
                    string sor = sr.ReadLine();
                    string[] sorDb = sor.Split(';');
                    for (int j = 0; j < sorDb.Length; j++)
                    {
                        ujtipp[i, j] = int.Parse(sorDb[j]);
                    }
                }
                sr.Close();
                return ujtipp;
            }
            catch
            {
                Console.WriteLine("A fileból olvasás közben hiba történt.");
                Console.ReadKey();
                return null;
            }
        }
    }
}