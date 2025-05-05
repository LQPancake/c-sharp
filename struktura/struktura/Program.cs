using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktura
{
    public struct Adatok
    {
        public string nev, lakcim, telefonszam;
        public int eletkor;
        public bool tanuloE;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Adatok> szemelyAdatok = new List<Adatok>();
            Adatok kis = new Adatok();
            kis.nev = "Kis Éva";
            kis.lakcim = "Ózd";
            kis.telefonszam = "+36 125";
            kis.eletkor = 21;
            kis.tanuloE = false;
            szemelyAdatok.Add(kis);
        }
    }
}
