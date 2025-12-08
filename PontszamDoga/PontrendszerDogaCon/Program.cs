using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontrendszerDogaLib;

namespace PontrendszerDogaCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a maximális pontszámot:\n---> ");
            int MaxPontInput = int.Parse(Console.ReadLine());

            while (true)
            {
                try
                {
                    Console.Write("Add meg a neved:\n---> ");
                    string NevInput = Console.ReadLine();
                    if (NevInput.ToLower() == "vége") break;
                    Console.Write("Add meg az elért pontszámod:\n---> ");
                    int PontSzamInput = int.Parse(Console.ReadLine());
                    Doga ujDoga = new Doga(NevInput, PontSzamInput, MaxPontInput);
                    Doga.PontszamokListaja.Add(ujDoga);
                }
                catch
                {
                    Console.WriteLine("Helytelen bevitel");
                }
            }
            Console.WriteLine("Adatlistázás");
            foreach (var doga in Doga.PontszamokListaja)
            {
                Console.WriteLine($"Név: {doga.Nev} | Pontszám: {doga.PontSzam}/{doga.MaxPontSzam} | Eredmény: {doga.Eredmeny()}% | Osztályzat: {doga.SzazalekEredmeny()}");
            }
            Console.ReadKey();
        }
    }
}
