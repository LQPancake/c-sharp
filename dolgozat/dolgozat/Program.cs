using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Baliga József 11/A

            int[] tomb = new int[15];
            int osszeg = 0;

            Random rsz = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rsz.Next(4000, 4201);
            }
            Console.Write("Számok: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < 15; i++)
            {
                if (tomb[i] == 4122)
                {
                    Console.WriteLine("A számok között szerepel a 4122!");
                }
                else
                {
                    Console.WriteLine("Nem szerepel a 4122.");
                }
            }
            for (int i = 0;i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine($"A számok összege {osszeg}");
            Console.ReadKey();
        }
    }
}
