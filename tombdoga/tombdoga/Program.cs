using System;

namespace tombdoga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0. Tömb feltöltés
            int[] tomb = new int[20];
            Random vsz = new Random();
            int osszeg = 0;
            bool vanBenne = false, vanBenneEgy = false;
            int darabszam = 0;
            int[] paros = new int[20];
            int parosIndex = 0;
            int[] pozitiv = new int[20];
            int pozitivIndex = 0, negativIndex = 0;
            int[] negativ = new int[20];
            int min = 0, max = 0;
            Console.WriteLine("Számok: ");
            // 1. összegzés, kiírás
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(-5, 6);
                osszeg += tomb[i];
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine($"\nÖsszeg: {osszeg}");
            // 2. Van-e benne -1?
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == -1)
                {
                    vanBenne = true;
                    break;
                }
            }
            if (vanBenne)
            {
                Console.WriteLine("Van benne -1");
            }
            else
            {
                Console.WriteLine("Nincs benne -1");
            }
            // 3. Hol van benne +1?
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 1)
                {
                    Console.WriteLine($"Van benne 1-es a tömb {i}. indexű helyén");
                    vanBenneEgy = true;
                }
            }
            if (!vanBenneEgy)
            {
                Console.WriteLine("Nincs benne 1-es");
            }
            // 4. Hány darab 5-ös van benne?
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 5)
                {
                    darabszam++;
                }
            }
            Console.WriteLine($"{darabszam}db 5-ös van benne");
            // 5. Válogassuk ki a párosokat
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    paros[parosIndex] = tomb[i];
                    parosIndex++;
                }
            }
            Console.WriteLine("Páros számok: ");
            for (int i = 0; i < parosIndex; i++)
            {
                Console.Write($"{paros[i]} ");
            }
            // 6. Válogassuk szét a pozitív-negatívokat
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > 0)
                {
                    pozitiv[pozitivIndex] = tomb[i];
                    pozitivIndex++;
                }
                if (tomb[i] < 0)
                {
                    negativ[negativIndex] = tomb[i];
                    negativIndex++;
                }
            }
            Console.WriteLine("\n Pozitív számok: ");
            for (int i = 0; i < pozitivIndex; i++)
            {
                Console.Write($"{pozitiv[i]} ");
            }
            Console.WriteLine("\n Negatív számok: ");
            for (int i = 0; i < negativIndex; i++)
            {
                Console.Write($"{negativ[i]} ");
            }
            // 7. Min-max
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine($"\nMinimum: {min} \nMaximum: {max}");
            Console.ReadKey();
        }
    }
}