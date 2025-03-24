using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tombgyak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tomb = tombGen();
            tombSort(tomb);
            filebaIr(tomb);
            Console.ReadKey();
        }
        public static int[] tombGen()
        {
            // Tömb feltöltés
            int[] tomb = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 41);
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine();
            return tomb;
        }
        public static void tombSort(int[] tomb)
        {
            // Tömb emelkedő sorrendbe rendezése
            Console.WriteLine($"A számok emelkedő sorba rendezve:\t");
            for (int i = 0;i < tomb.Length - 1;i++)
            {
                for(int j = 0; j < tomb.Length - 1 - i; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int segito = tomb[j];
                        tomb[j] = tomb[j+1];
                        tomb[j+1] = segito;
                    }
                }
            }
            for (int i = 0; i < tomb.Length ; i++)
            {
                Console.Write($"{tomb[i]} ");
            }
        }
        public static void filebaIr(int[] tomb, string filenev="lista.txt")
        {
            try
            {
                StreamWriter sw = new StreamWriter(filenev);
                for (int i = 0; i < tomb.Length; i++)
                {
                    sw.Write($"{tomb[i]} ");
                }
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Hiba a fileba írás során! GATYA ROTTY!!!");
            }
            Console.WriteLine("");
            Console.WriteLine("Fileba kiírva!");
        }
    }
}
