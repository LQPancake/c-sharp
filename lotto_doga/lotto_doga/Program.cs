using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto_doga
{
    internal class Program
    {
        public int sorok = 20;
        public int oszlop = 6;
        public int tartomany = 45;
        static void Main(string[] args)
        {
            var szam = lottoGen();
            kiIr(szam);
            Console.ReadKey();
        }
        public static int[] lottoGen(int[] tomb)
        {
            Random rnd = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; i < tomb.Length - 1; j++)
                {
                    tomb[i] = rnd.Next(1, 46);
                }
            }
            return tomb;
        }
        public static void kiIr(int[] tomb)
        {
            for(int i = 0;i < tomb.Length;i++)
            {
                Console.WriteLine($"{tomb[i]} ");
            }
        }
        public static void filebaIr(string filename = "lottoszamok.csv")
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);

                sw.Close();
                Console.WriteLine("Számok fileba írva.");
            }
            catch
            {
                Console.WriteLine("A fileba írás közben hiba történt.");
            }
        }
        public static void filebolOlvas()
        {
            try
            {
                Console.WriteLine("A lottószámok fileból olvasva:");
                StreamReader sr = new StreamReader("lottoszamok.csv");

                sr.Close();
            }
            catch
            {
                Console.WriteLine("A fileból olvasás közben hiba történt.");
            }
        }
    }
}
