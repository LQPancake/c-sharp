using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyfa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a karácsonyfa magasságát:");
        int magassag = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        char[] diszek = { 'O', '@', '*' };
        // Lomb
        for (int i = 1; i <= magassag; i++)
        {
            // Szóközök (középre igazítás)
            for (int j = 0; j < magassag - i; j++)
            {
                Console.Write(" ");
            }
            // Ágak + díszek
            for (int k = 0; k < 2 * i - 1; k++)
            {
                // Véletlenszerűen dísz vagy ág
                if (rnd.Next(0, 5) == 0)
                {
                    Console.Write(diszek[rnd.Next(diszek.Length)]);
                }
                else
                {
                    Console.Write("^");
                }
            }

            Console.WriteLine();
        }
        // Törzs
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < magassag - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }
        }
    }
}
