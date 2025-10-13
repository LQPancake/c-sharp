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
        static List<Helyiseg> placeList = new List<Helyiseg>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            placeList = Helyiseg.readFile("places.csv");
            placeList = Helyiseg.DataLoader();
            Helyiseg.saveFile(placeList);
            Helyiseg.HelyisegLister(placeList);
            Console.ReadKey();
        }
    }
}
