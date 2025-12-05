using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorClassLibrary
{
    public class Kor
    {
        public double Sugar { get; private set; }
        public static int KorokSzama { get; private set; } = 0;
        public Kor(double sugar)
        {
            this.Sugar = sugar;
            KorokSzama++;
        }
        public double KorKerulet()
        {
            return Math.Round(this.Sugar * 2 * Math.PI, 2);
        }
        public double KorTerulet()
        {
            return Math.Round(Math.Pow(this.Sugar,2) * Math.PI, 2);
        }
        public static double StaticKorKerulet(double sugar)
        {
            return Math.Round(sugar * 2 * Math.PI, 2);
        }
    }
}
