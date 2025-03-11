using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombgyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feltöltés
            int[] tomb = new int[20];
            Random vsz = new Random();
            int osszegzes = 0;
            Console.WriteLine("Számok: ");
            // Kiírás, összegzés
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(-10, 11);
                Console.Write($"{tomb[i]} ");
                osszegzes++;
            }
            Console.WriteLine($"\nSzámok összege: {osszegzes}");
            // Van-e benne 1
            bool vanBenne = false;
            for (int i = 0;i < tomb.Length;i++)
            {
                if (tomb[i] == 1)
                {
                    vanBenne = true;
                    break;
                }
            }
            if (vanBenne)
            {
                Console.WriteLine("Van benne 1-es");
            }
            else
            {
                Console.WriteLine("Nincs benne 1-es");
            }
            // Hol van benne -1
            bool vanBenneMinusz = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == -1)
                {
                    Console.WriteLine($"A -1-es a tömb {i+1}. indexű helyén van");
                    vanBenneMinusz= true;
                }
            }
            if (!vanBenneMinusz)
            {
                Console.WriteLine("Nincs benne -1es");
            }
            // Hány db páros?
            int darabszam = 0;
            for (int i = 0; i < tomb.Length ; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    darabszam++;
                }
            }
            Console.WriteLine($"{darabszam}db páros szám van");
            // Negatívok kiválogatása
            int[] negativok = new int[20];
            int negativIndex = 0;
            for(int i = 0;i < tomb.Length; i++)
            {
                if (tomb[i] < 0)
                {
                    negativok[negativIndex] = tomb[i];
                    negativIndex++;
                }
            }
            Console.WriteLine("Negatív számok: ");
            for (int i = 0; i < negativIndex; i++)
            {
                Console.Write($"{negativok[i]} ");
            }
            // Páros-Páratlan szétválogatás
            int[] paros = new int[20];
            int[] paratlan = new int[20];
            int parosIndex = 0;
            int paratlanIndex = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    paros[parosIndex] = tomb[i];
                    parosIndex++;
                }
                else
                {
                    paratlan[paratlanIndex] = tomb[i];
                    paratlanIndex++;
                }
            }
            Console.WriteLine("\nPáros számok: ");
            for (int i = 0; i < parosIndex; i++)
            {
                Console.Write($"{paros[i]} ");
            }
            Console.WriteLine("\nPáratlan számok: ");
            for (int i = 0; i < paratlanIndex; i++)
            {
                Console.Write($"{paratlan[i]} ");
            }
            // min-max
            int min = 0;
            int max = 0;
            for(int i = 0;i < tomb.Length;i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine($"\nMin: {min} Max: {max}");
            Console.ReadKey();
        }
    }
}
