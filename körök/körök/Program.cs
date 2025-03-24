using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace körök
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kor_sugarak = input();
            korTer(kor_sugarak);
            korKer(kor_sugarak);
            FileIras(kor_sugarak, "lista.txt");
            var tomb2 = FileKI("lista.txt");
            Console.ReadKey();
        }
        public static double[] input()
        {
            Console.Write("Hány körnek az adatait tároljuk: ");
            int korok = int.Parse(Console.ReadLine());
            int[] sugarak = new int[korok];
            double[] kor_sugarak = new double[korok];
            for (int i = 0; i < korok; i++)
            {
                Console.WriteLine($"Add meg az {i+1}.-ik kör sugarát: ");
                kor_sugarak[i] = double.Parse(Console.ReadLine());
            }
            return kor_sugarak;
        }
        public static void korTer(double[] korTomb)
        {
            for (int i = 0; i < korTomb.Length; i++)
            {
                Console.WriteLine($"A(z) {i + 1}. kör területe: {korTomb[i] * korTomb[i] * 3.14} cm²");
            }
        }
        public static void korKer(double[] korTomb)
        {
            for(int i = 0;i < korTomb.Length; i++)
            {
                Console.WriteLine($"A(z) {i+1}. kör kerülete: {2 * korTomb[i] * 3.14} cm");
            }
        }
        public static void FileIras(double[] kor_sugarak, string filenev="lista.txt")
        {
            try
            {
                StreamWriter sw = new StreamWriter(filenev);
                for (int i = 0; i < kor_sugarak.Length; i++)
                {
                    sw.WriteLine($"{kor_sugarak[i]}\t");
                }
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Hiba a fájlkezelés során! GATYA ROTTY!");
            }
        }
        public static int[] FileKI(string filenev="lista.txt")
        {
            try
            {
                Console.WriteLine($"A '{filenev}' tartalma:\t");
                StreamReader sr = new StreamReader(filenev);
                int sorokSzama = 0;
                while (!sr.EndOfStream)
                {
                    //string line = sr.ReadLine();
                    //Console.WriteLine(line);
                    Console.WriteLine(sr.ReadLine());
                    sorokSzama++;
                }
                sr.Close();

                StreamReader sr2 = new StreamReader(filenev);
                int[] tombFilebol = new int[sorokSzama];
                int tombIndex = 0;
                while (!sr2.EndOfStream)
                {
                    tombFilebol[tombIndex] = int.Parse(sr2.ReadLine());
                    tombIndex++;
                }
                sr2.Close();
                return tombFilebol;
            }
            catch
            {
                Console.WriteLine("Hiba a fájl beolvasása során! GATYA ROTTY!");
                return null;
            }
        }
    }
}
