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
        static List<Helyiseg> placeList;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Helyiseg.Converter("places.csv", "festo.csv");
            placeList = Helyiseg.readFile("places.csv");
            placeList = Helyiseg.DataLoader();
            Helyiseg.saveFile("places.csv", placeList);
            Helyiseg.HelyisegLister(placeList);
            var newObj1 = new Helyiseg("a", "b", 2.4, 5.4);
            var newObj2 = new Helyiseg("a", "b", 2.4, 5.4, 2.7);
            Console.ReadKey();
        }
    }
}
