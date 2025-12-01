using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikidomokLibrary
{
    public class Kor
    {
        public double Sugar { get; private set; }
        public static List<Kor> KorokListaja = new List<Kor>();
        public static double OsszesKerulet { get; private set; } = 0;
        public static double OsszesTerulet { get; private set; } = 0;
        public Kor(double sugar)
        {
            this.Sugar = sugar;
            KorokListaja.Add(this);
            OsszesKerulet += this.KorKerulet();
            OsszesTerulet += this.KorTerulet();
        }
        public double KorKerulet()
        {
            return Math.Round(this.Sugar * 2 * Math.PI, 2);
        }
        public double KorTerulet()
        {
            return Math.Round(Math.Pow(this.Sugar, 2) * Math.PI, 2);
        }
    }
}
