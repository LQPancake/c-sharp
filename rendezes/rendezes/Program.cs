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
            var tomb = TombGyar();
            Kiiras(tomb);
            Rendez(tomb);
            Kiiras(tomb);
            Console.ReadKey();
        }

        static void TombGyar(int[] ujTomb)
        {
            int hossz, legkis, legnagy;
            Console.WriteLine("Mennyire hosszú legyen a tömb");
            hossz = int.Parse(Console.ReadLine());
            Console.WriteLine("Mennyi legyen a legkisebb érték a tömbbe");
            legkis = int.Parse(Console.ReadLine());
            Console.WriteLine("Mennyi legyen a legnagyobb érték a tömbbe");
            legnagy = int.Parse(Console.ReadLine());
            Random vsz = new Random();
            int[] ujTomb = new int[hossz];
            for (int i = 0; i < ujTomb.Length; i++)
            {
                ujTomb[i] = vsz.Next(legkis, legnagy);
            }
            return ujTomb;
        }

        static void Kiiras(int[] kapottTomb)
        {
            for (int i = 0; i < kapottTomb.Length; i++)
            {
                Console.Write($"{kapottTomb[i]}\t");
            }
            Console.WriteLine();
        }
        static void Rendez(int[] KapottTomb, int merre=0)
        {
            if (merre == 0)
            {
                return;
            }
            for (int i = 0; i > KapottTomb.Length - 1; i++)
            {
                for (int j = 0; j < KapottTomb.Length - i - 1; j++)
                {
                    if (merre < 0)
                    {
                        if (KapottTomb[j] < KapottTomb[j + 1])
                        {
                            int seged = KapottTomb[j];
                            KapottTomb[j] = KapottTomb[j + 1];
                            KapottTomb[j + 1] = seged;
                        }
                    }
                    else
                    {

                    }
                }

            }
        }

        static int Osszeadas(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
