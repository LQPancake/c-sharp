using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11A_buborek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tomb = tombGyar();

            Kiiras(tomb);
            Rendez(tomb, 1);
            Kiiras(tomb);
            Console.ReadKey();
        }


        public static void Kiiras(int[] kapottTomb)
        {
            for (int i = 0; i < kapottTomb.Length; i++)
            {
                Console.Write($"{kapottTomb[i]}\t");
            }
            Console.WriteLine();
        }

        public static void Rendez(int[] kapottTomb, int merre = 0)
        {
            if (merre == 0)
            {
                return;
            }
            for (int i = 0; i < kapottTomb.Length - 1; i++)
            {
                for (int j = 0; j < kapottTomb.Length - i - 1; j++)
                {
                    if (merre < 0)
                    {
                        if (kapottTomb[j] < kapottTomb[j + 1])
                        {
                            int seged = kapottTomb[j];
                            kapottTomb[j] = kapottTomb[j + 1];
                            kapottTomb[j + 1] = seged;
                        }
                    }
                    else
                    {
                        if (kapottTomb[j] > kapottTomb[j + 1])
                        {
                            int seged = kapottTomb[j];
                            kapottTomb[j] = kapottTomb[j + 1];
                            kapottTomb[j + 1] = seged;
                        }
                    }

                }
            }
        }

        public static int[] tombGyar()
        {
            int meret, tol, ig;
            Console.Write("Tömb mérete: ");
            meret = int.Parse(Console.ReadLine());
            Console.Write("\nTÓL: ");
            tol = int.Parse(Console.ReadLine());
            Console.Write("\nIG: ");
            ig = int.Parse(Console.ReadLine());
            Random vsz = new Random();
            int[] tomb = new int[meret];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(tol, ig + 1);
            }
            return tomb;
        }
    }
}
    