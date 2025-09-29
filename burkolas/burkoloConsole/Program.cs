using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burkoloConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helyiseg szoba = new Helyiseg();
            szoba.Name = "Hálószoba";
            szoba.Description = "padlóburkolat";
            szoba.Length = 4.18;
            szoba.Width = 3.5;
            Console.WriteLine($"{szoba.Name}, terület: {szoba.Length * szoba.Width}m2");
            Console.ReadKey();
        }
    }
}
