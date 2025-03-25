using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_tomb
{
    internal class Program
    {
        static int sorokSzama = 10;

        static void Main(string[] args)
        {
            var tippek = Sorsolo(sorokSzama);
            Kiir(tippek);
            FilebaIr(tippek, "tippek.csv");
            var ujtippek = FileOlvas("tippek.csv");
            Kiir(ujtippek);
            Console.ReadKey();
        }
        public static int[,] Sorsolo(int sorokSzama)
        {
            Random vsz = new Random();
            int[,] szamok = new int[sorokSzama, 5];
            for (int h = 0; h < sorokSzama; h++)
            {
                int[] sor = new int[5];
                for(int i = 0; i < sor.Length; i++)
                {
                    int szam = vsz.Next(1, 91);
                    while (sor.Contains(szam))
                    {
                        szam = vsz.Next(1, 91);
                    }
                    sor[i] = szam;
                }
                Array.Sort(sor);
                for (int i = 0;i < sor.Length; i++)
                {
                    szamok[h, i] = sor[i];
                }
                
            }
            return szamok;
        }
        public static void Kiir(int[,] tippek)
        {
            for (int i = 0; i < tippek.GetLength(0); i++)
            {
                for(int j = 0; j < tippek.GetLength(1); j++)
                {
                    Console.Write($"{tippek[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void FilebaIr(int[,] tippek, string filenev)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filenev);
                for(int i = 0; i < tippek.GetLength(0); i++)
                {
                    for(int j = 0; j < tippek.GetLength(1); j++)
                    {
                        sw.Write(tippek[i, j]);
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
                Console.WriteLine("A számok kiírása közben hiba történt! GATYA ROTTY!");
            }
        }
        public static int[,] FileOlvas(string filenev)
        {
            Console.WriteLine("A számok a fileból beolvasva:");
            try
            {
                int[,] ujtipp = new int[sorokSzama, 5];
                StreamReader sr = new StreamReader(filenev);
                for (int i = 0; i < ujtipp.GetLength(0); i++)
                {
                    string sor = sr.ReadLine();
                    string[] sorDb = sor.Split(';');
                    for(int j = 0;j < sorDb.Length; j++)
                    {
                        ujtipp[i, j] = int.Parse(sorDb[j]);
                    }
                }
                sr.Close();
                return ujtipp;
            }
            catch
            {
                Console.WriteLine("Hiba történt a file beolvasása közben! GATYA ROTTY!");
                return null;
            }
        }
    }
}
