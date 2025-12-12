using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KonyvLibGyak;

namespace KonyvCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Write("Add meg a könyv címét:\n---> ");
                    string CimInput = Console.ReadLine();
                    if (CimInput.ToLower() == "stop") break;
                    Console.Write("Add meg a könyv szerzőjét:\n---> ");
                    string SzerzoInput = Console.ReadLine();
                    Console.Write("Add meg a könyv oldalszámát:\n---> ");
                    int LapokSzamaInput = int.Parse(Console.ReadLine());
                    KonyvLib ujKonyv = new KonyvLib(CimInput, SzerzoInput, LapokSzamaInput);
                    KonyvLib.Konyvek.Add(ujKonyv);
                }
                catch
                {
                    Console.WriteLine("Helytelen bevitel");
                }
            }
            Console.WriteLine("Összegzés:");
            foreach (var konyv in KonyvLib.Konyvek)
            {
                Console.WriteLine($"A könyv címe: {konyv.Cim} | A könyv szerzője: {konyv.Szerzo} | A könyv oldalszáma: {konyv.LapokSzama} | A könyv olvasási ideje: {konyv.OlvasasiIdo()} perc | Példányok száma: {konyv.KonyvekSzama}");
            }
            Console.ReadKey();
        }
    }
}
