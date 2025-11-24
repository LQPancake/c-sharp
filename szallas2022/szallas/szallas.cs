using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallasLibrary
{
    public class Szallas
    {
        public string _szallasNeve;
        /// <summary>
        /// A szállás nevét tartalmazza
        /// </summary>
        public string _SzallasNeve { get; private set; }
        public string SzallasCime { get; private set; }
        public int SzobaSzam { get; private set; }
        public int AgySzam { get; private set; }
        public string UzemeltetoNev { get; private set; }
        public string UzemeltetoCim { get; private set; }
        public string UzemeltetoTelefonSzam { get; private set; }
        public bool Statusz { get; private set; }
        public string TevekenysegTipus { get; private set; }
        public static List<Szallas> SzallasokListaja = new List<Szallas>();
        public static Dictionary<string, int> TelepulesekDictionary = new Dictionary<string, int>();
        public static int SzallasDarab { get; private set; } = 0;
        public static int AktivSzallasokSzama { get; private set; } = 0;
        public static int AktivAgyszam { get; private set; } = 0;
        /// <summary>
        /// A Szallas osztály konstruktora, ami egy adatfile soraiból objektumot készít
        /// </summary>
        /// <param name="sor">A beolvasandó file neve</param>
        public Szallas(string sor)
        {
            string[] db = sor.Split(';');
            this._SzallasNeve = db[0];
            this.SzallasCime = db[1];
            this.SzobaSzam = int.Parse(db[2]);
            this.AgySzam = int.Parse(db[3]);
            this.UzemeltetoNev = db[4];
            this.UzemeltetoCim = db[5];
            this.UzemeltetoTelefonSzam = db[6];
            if (db[7] == "Aktív")
            {
                this.Statusz = true;
            }
            else
            {
                this.Statusz = false;
            }
            this.TevekenysegTipus = db[8];
            SzallasDarab++;
            if(this.Statusz == true)
            {
                AktivSzallasokSzama++;
                AktivAgyszam += this.AgySzam;
            }
        }
        /// <summary>
        /// A paraméterben szereplő file soraiból listát készít
        /// </summary>
        /// <param name="filename">A betöltendő file neve</param>
        /// <returns>A file soraiból készített lista</returns>
        /// <exception cref="Exception">Hiba üzenet, ha a file műveletek elakadnak</exception>
        public static List<Szallas> FileBetoltes(string filename)
        {
            try
            {
                var sr = new StreamReader(filename, Encoding.UTF8);
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var ujObjektum = new Szallas(sr.ReadLine());
                    SzallasokListaja.Add(ujObjektum);
                }
                sr.Close();
            }
            catch
            {
                throw new Exception("Értesítse a programozó! \n" + "+36301234567 számon\n" +  "A hiba a SZALLAS.FILEBETOLTES helyen található");
            }
            return SzallasokListaja;

        }
        public static Dictionary<string, int> TelepulesekValogato(List<Szallas> lista)
        {
            foreach (var szallas in lista)
            {
                string telepulesNeve = szallas.SzallasCime.Split(' ')[1];
                if (!szallas.Statusz)
                {
                    continue;
                }
                if (TelepulesekDictionary.ContainsKey(telepulesNeve))
                {
                    TelepulesekDictionary[telepulesNeve]++;
                }
                else
                {
                    TelepulesekDictionary.Add(telepulesNeve, 1);
                }
            }
            return TelepulesekDictionary;
        }
    }
}
