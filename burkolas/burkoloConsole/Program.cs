using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace burkoloConsole
{
    internal class Program1 
    {
        static void Main(string[] args)
        {
            var placeList = Helyiseg.DataLoader();
            foreach (Helyiseg h in placeList)
            {
                Console.WriteLine($"{h.Name} terület: {h.Area()}m\u00B2");
            }
            
            Console.WriteLine($"A 3,5 * 4.5 m-es szoba területe: {Helyiseg.AreaStatic(3.5, 4.5)}\u00B2");
            Helyiseg.saveFile(placeList);
            var readFile = Helyiseg.readFile();
            Console.ReadKey();
        }
    }
}
