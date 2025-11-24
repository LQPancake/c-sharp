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
            //létrehozunk egy lista nevű listát, ami a megadott file sorainak adatait tartalmazza
            List<Szallas> lista = new List<Szallas>();
            try
            {
                lista = Szallas.FileBetoltes("szallas2022.csv");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }
            //4. feladat megoldasa
            feladat(4);
            Console.WriteLine($"Az összes szálláshelyek száma: {lista.Count} db");
            Console.WriteLine($"Az összes szálláshelyek száma: {Szallas.SzallasDarab} db");
            //5. feladat megoldasa
            feladat(5);
            Console.WriteLine($"Átlagos ágyszám az aktív szálláshelyeken: {(double)Szallas.AktivAgyszam/(double)Szallas.AktivSzallasokSzama:f}");
            //6. feladat megoldasa
            feladat(6);
            Console.WriteLine("Szeghalom környéki aktív szállások:");
            var telepulesDict = Szallas.TelepulesekValogato(lista);
            foreach(var sor in telepulesDict)
            {
                Console.WriteLine($"\t{sor.Key} : {sor.Value} db");
            }
            Console.ReadKey();

        }
        public static void feladat(int sorszam)
        {
            Console.WriteLine($"{sorszam}. feladat");
        }
    }
}
