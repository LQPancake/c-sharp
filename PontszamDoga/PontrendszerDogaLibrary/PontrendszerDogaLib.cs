using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PontrendszerDogaLib
{
    public class Doga
    {
        public static List<Doga> PontszamokListaja = new List<Doga>();
        public string Nev { get; private set; }
        public int PontSzam { get; private set; }
        public int MaxPontSzam { get; private set; }
        public Doga(string nev, int pontszam, int maxpontszam)
        {
            this.Nev = nev;
            this.PontSzam = pontszam;
            this.MaxPontSzam = maxpontszam;
        }
        public int Eredmeny()
        {
            double eredmeny = (double)PontSzam / MaxPontSzam * 100;
            return Convert.ToInt32(Math.Round(eredmeny));
        }
        public int SzazalekEredmeny()
        {
            int eredmeny = Eredmeny();

            if (eredmeny >= 90) return 5;
            else if (eredmeny >= 75) return 4;
            else if (eredmeny >= 60) return 3;
            else if (eredmeny >= 40) return 2;
            else return 1;
        }

    }
}
