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
            Console.WriteLine("Kör vagy téglalap? (k/t)");
            string valaszInput = Console.ReadLine();
            if (valaszInput.ToLower() == "k")
            {
                // Kör
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
                foreach (var kor in Kor.KorokListaja)
                {
                    Console.WriteLine($"A(z) {kor.Sugar} sugarú kör kerülete: {kor.KorKerulet()} Területe: {kor.KorTerulet()}");
                }
                Console.WriteLine($"\nÖsszes kerület: {Kor.OsszesKerulet}\n" +
                    $"Összes terület: {Kor.OsszesTerulet}");

            }
            else if (valaszInput.ToLower() == "t")
            {
                // Téglalap
                Console.WriteLine("2. rész: Téglalap adatok gyűjtése\n" +
                        "\t Add meg a téglalap 'a' oldalát (üres ENTER=vége)\n");
                while (true)
                {
                    Console.Write("Add meg a téglalap 'a' oldalát (ENTER=vége)\n---> ");
                    string aInput = Console.ReadLine();
                    if (aInput == "") { break; }

                    Console.Write("Add meg a téglalap 'b' oldalát\n---> ");
                    string bInput = Console.ReadLine();

                    try
                    {
                        double aOldal = double.Parse(aInput);
                        double bOldal = double.Parse(bInput);

                        if (aOldal > 0 && bOldal > 0)
                        {
                            var ujObj2 = new Teglalap(aOldal, bOldal);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Helyes adatokat kérek!");
                    }
                }

                Console.WriteLine("\nTéglalapok adatainak listázása\n");
                foreach (var teglalap in Teglalap.TeglalapokListaja)
                {
                    Console.WriteLine($"A(z) {teglalap.aOldal} a oldalú és {teglalap.bOldal} b oldalú téglalap kerülete: {teglalap.TeglalapKerulet()}\n" +
                        $"területe: {teglalap.TeglalapTerulet()} ");
                }
                Console.WriteLine($"\nÖsszes kerület: {Teglalap.OsszesKerulet}\n" +
                    $"Összes terület: {Teglalap.OsszesTerulet}");

            }
            else
            {
                Console.WriteLine("Helytelen válasz:((((((((((((((((((((((");
            }
                Console.ReadKey();
        }
    }
}
