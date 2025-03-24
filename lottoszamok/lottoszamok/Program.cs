using System;

namespace lottoszamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] lottoszamok = new int[5];
            Console.WriteLine("A lottószámok:");
            for (int i = 0; i < lottoszamok.Length; i++)
            {
                int ujSzam;
                bool ismSzam = false;
                for (int j = 0; j < 1; j++)
                {
                    if (lottoszamok[j] == ujSzam)
                    {
                        ismSzam = true;
                    }
                }
                Console.WriteLine($"{lottoszamok[i]}\t");
            }
            Console.ReadKey();
        }
    }
}
