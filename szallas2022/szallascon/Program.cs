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
            var lista = Szallas.FileBetoltes("szallas2022.csv");
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
            Dictionary<string, int> telepulesDict = new Dictionary<string, int>();
            foreach(var szallas in lista)
            {
                string telepulesNeve = szallas.SzallasCime.Split(' ')[1];
                if (!szallas.Statusz)
                {
                    continue;
                }
                if (telepulesDict.ContainsKey(telepulesNeve))
                {
                    telepulesDict[telepulesNeve]++;
                }
                else
                {
                    telepulesDict.Add(telepulesNeve, 1);
                }
            }
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
