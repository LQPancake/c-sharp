using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikidomDogaLibrary
{
    public class Kor
    {
        public double Sugar { get; private set; }
        public static List<Kor> KorokListaja = new List<Kor>();
        public static double OsszesKerulet { get; private set; } = 0;
        public static double OsszesTerulet { get; private set; } = 0;
        /// <summary>
        /// Kör objektumot hoz létre
        /// </summary>
        /// <param name="sugar">A kör sugara, double típus</param>
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
    public class Teglalap
    {
        public double aOldal { get; private set; }
        public double bOldal { get; private set; }
        public static List<Teglalap> TeglalapokListaja = new List<Teglalap>();
        public static double OsszesKerulet { get; private set; } = 0;
        public static double OsszesTerulet { get; private set; } = 0;
        /// <summary>
        /// Téglalap objektumot hoz létre
        /// </summary>
        /// <param name="aOldal">A téglalap a oldala, double típus</param>
        /// <param name="bOldal">A téglalap b oldala, double típus</param>
        public Teglalap(double aOldal, double bOldal)
        {
            this.aOldal = aOldal;
            this.bOldal = bOldal;
            TeglalapokListaja.Add(this);
            OsszesKerulet += this.TeglalapKerulet();
            OsszesTerulet += this.TeglalapTerulet();
        }
        public double TeglalapKerulet()
        {
            return Math.Round(2 * (this.aOldal + this.bOldal), 2);
        }
        public double TeglalapTerulet()
        {
            return Math.Round(this.aOldal * this.bOldal, 2);
        }
    }
}
