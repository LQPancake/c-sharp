using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Baliga József
            // C csoport
            int[] tomb = new int[19];
            Random vsz = new Random();
            int osszeg = 0;
            // Véletlen szám, összegzés
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(61,85);
                osszeg += tomb[i];
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine($"\nA számok összege: {osszeg}");
            // Eldöntés
            bool vanBenne = false;
            for (int i = 0;i < tomb.Length;i++)
            {
                if (tomb[i] == 71)
                {
                    vanBenne = true;
                }
            }
            if (vanBenne)
            {
                Console.WriteLine("Van benne 71");
            }
            else
            {
                Console.WriteLine("Nincs benne 71");
            }
            // Megszámolás
            int oszthato = 0;
            for (int i = 0;i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    oszthato ++;
                }
            }
            Console.WriteLine($"{oszthato}db 3-mal osztható szám van");
            Console.ReadKey();
        }
    }
}
