using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using szallasLibrary;

namespace szallascon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = Szallas.FileBetoltes("szallas2022.csv");
            //4. feladat megoldasa
            feladat(4);
            Console.WriteLine($"Az összes szálláshelyek száma: {lista.Count} db");
            Console.WriteLine($"Az összes szálláshelyek száma: {Szallas.SzallasDarab} db");
            //5. feladat megoldasa
            feladat(5);
            Console.WriteLine($"Átlagos ágyszám az aktív szálláshelyeken: {(double)Szallas.AktivAgyszam/(double)Szallas.AktivSzallasokSzama:f}");

            Console.ReadKey();

        }
        public static void feladat(int sorszam)
        {
            Console.WriteLine($"{sorszam}. feladat");
        }
    }
}
