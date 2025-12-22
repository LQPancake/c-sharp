using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvLibGyak
{
    public class KonyvLib
    {
        public static List<KonyvLib> Konyvek = new List<KonyvLib>();
        public string Cim { get; private set; }
        public string Szerzo { get; private set; }
        public int LapokSzama { get; private set; }
        public int KonyvekSzama { get; private set; } = 0;
        public KonyvLib(string cim, string szerzo, int lapokSzama)
        {
            this.Cim = cim;
            this.Szerzo = szerzo;
            this.LapokSzama = lapokSzama;
            KonyvekSzama++;
        }
        public int OlvasasiIdo()
        {
            return LapokSzama * 4;
        }
    }
}
