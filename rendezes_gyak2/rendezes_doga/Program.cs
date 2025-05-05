using System;
using System.IO;
using System.Linq;

namespace lotto_doga
{
    internal class Program
    {
        public static int sorSzam = 20;
        public static int oszlopSzam = 6;
        public static int tartomany = 45;
        static void Main(string[] args)
        {
            var tipp = lottoGen(sorSzam, oszlopSzam, tartomany);
            kiIras(tipp);
            filebaIr(tipp, "tippek.csv");
            var ujtipp = filebolOlvas("tippek.csv");
            kiIras(ujtipp);
            Console.ReadKey();
        }
        public static int[,] lottoGen(int sorSzam, int oszlopSzam, int tartomany)
        {
            int[,] szamok = new int[sorSzam, oszlopSzam];
            Random rnd = new Random();
            for (int i = 0; i < sorSzam; i++)
            {
                int[] sor = new int[oszlopSzam];
                for (int j = 0; j < oszlopSzam; j++)
                {
                    int szam = rnd.Next(1, tartomany + 1);
                    while (sor.Contains(szam))
                    {
                        szam = rnd.Next(1, tartomany + 1);
                    }
                    sor[j] = szam;
                }
                Rendezes(sor);
                for (int j = 0; j < oszlopSzam; j++)
                {
                    szamok[i, j] = sor[j];
                }
            }
            return szamok;
        }
        public static void Rendezes(int[] sor)
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
        public static void kiIras(int[,] tomb)
        {
            Console.Write($"Lottóba tippelt számok:\n");
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write($"{tomb[i, j]}");
                    if (j == 4)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(';');
                    }
                }
            }
        }
        public static void filebaIr(int[,] szamok, string filenev)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filenev);
                for (int i = 0;i < szamok.GetLength(0); i++)
                {
                    for(int j = 0;j < szamok.GetLength(1); j++)
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
        public static int[,] filebolOlvas(string filenev)
        {
            try
            {
                int[,] ujtipp = new int[sorSzam, oszlopSzam];
                StreamReader sr = new StreamReader(filenev);
                for (int i = 0; i < ujtipp.GetLength(0); i++)
                {
                    string sor = sr.ReadLine();
                    string[] sorDb = sor.Split(';');
                    for (int j = 0; j < sorDb.Length; j++)
                    {
                        ujtipp[i,j] = int.Parse(sorDb[j]);
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