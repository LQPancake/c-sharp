using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SikidomokLibrary;

namespace SikidomokCon2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. rész: Kör adatok gyűjtése\n" +
                "\tAdd meg a kör sugarát (üres ENTER=vége)\n");
            while (true)
            {
                Console.Write("---> ");
                string input = Console.ReadLine();
                if (input == "") { break; }
                try
                {
                    double sugar = double.Parse(input);
                    if (sugar > 0)
                    {
                        //példányosítás
                        var ujObj = new Kor(sugar);
                    }
                    else { continue; }
                }
                catch
                {
                    Console.WriteLine("Helyes adatokat kérek!");
                }
            }
            Console.WriteLine("\nKörök adatainak listázása\n");
            foreach(var kor in Kor.KorokListaja)
            {
                Console.WriteLine($"A(z) {kor.Sugar} sugarú kör kerülete: {kor.KorKerulet()} Területe: {kor.KorTerulet()}");
            }
            Console.WriteLine($"\nÖsszes kerület: {Kor.OsszesKerulet}\n" +
                $"Összes terület: {Kor.OsszesTerulet}");
            Console.ReadKey();
        }
    }
}
