using System;

namespace gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6os lotto
int[] tippek = new int[6];
for (int i = 0; i < tippek.Length; i++)
{
Console.Write($"Add meg a(z) {i + 1}. számot 1-45 közt: ");
tippek[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nTippjeid: \n");
for (int i = 0; i < tippek.Length; i++)
{
Console.Write($"{tippek[i]}\t");
}
Console.WriteLine();
Random vsz = new Random();
int[] lotto = new int[6];
for (int i = 0; i < lotto.Length; i++)
{
lotto[i] = vsz.Next(1, 46);
}
Console.WriteLine("\nA lottószámok: \n");
for (int i = 0; i < lotto.Length; i++)
{
Console.Write($"{lotto[i]}\t");
}
Console.WriteLine();
for (int i = 0;i < tippek.Length; i++)
{
for (int j = 0;j < lotto.Length; j++)
{
if (tippek[i] == lotto[j])
{
    Console.WriteLine($"Ez talált: {tippek[i]}");
}
}
}
Console.WriteLine();
*/

            /* szoba
            Console.WriteLine("Hány szobád van? ");
            int xSzoba = int.Parse(Console.ReadLine());
            double[] szobaOsszeg = new double[xSzoba];
            double[] terulet = new double[xSzoba];
            double[] hossz = new double[xSzoba];
            double[] szel = new double[xSzoba];
            double osszTerulet = 0;
            for (int i = 0; i < szobaOsszeg.Length; i++)
            {
                Console.WriteLine($"Hány méter hosszú a(z) {i+1}. szoba? ");
                hossz[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"Hány méter széles a(z) {i+1}. szoba? ");
                szel[i] = double.Parse(Console.ReadLine());
                terulet[i] = hossz[i] * szel[i];
                Console.WriteLine($"A(z) {i+1}. szobának a területe: {terulet[i]} m2");
                osszTerulet = osszTerulet + terulet[i];
            }
            Console.WriteLine($"Az összesnek a területe: {osszTerulet} m2");
            Console.WriteLine();
            */

            /*
            // összegzési tétel
            int[] tomb = new int[100];
            int osszegzes = 0;
            Random vsz = new Random();
            Console.WriteLine("A tömb elemei: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(1, 151);
                osszegzes += tomb[i];
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine($"\n\nTömb elemeinek összege: {osszegzes}");

            // megszámolási tétel
            int darab = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    darab++;
                }
            }
            Console.WriteLine($"{darab}db 3-mal osztható szám van");

            // eldöntési tétel
            bool vanBenne = false;
            for (int i = 0;i < tomb.Length; i++)
            {
                if (tomb[i] % 12 == 0)
                {
                    vanBenne = true;
                    break;

                }
            }
            if(vanBenne)
            {
                Console.WriteLine("van 12-vel osztható szám");
            }
            else
            {
                Console.WriteLine("nincs 12-vel osztható szám");
            }
            */

            /*
            int[] tomb = new int[10];
            Random vsz = new Random();
            int osszeg = 0;
            // osszegzes
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(1, 21);
                osszeg += tomb[i];
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine($"\nA számok összege: {osszeg}");
            bool vanE = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 12)
                {
                    vanE = true;
                }
            }
            // eldontes
            if (vanE)
            {
                Console.WriteLine("Van benne 12-es");
            }
            else
            {
                Console.WriteLine("Nincs benne 12-es");
            }
            // megszamolas
            int darab = 0;
            for(int i = 0;i < tomb.Length; i++)
            {
                if (tomb[i] % 2 != 0)
                {
                    darab += 1;
                }
            }
            Console.WriteLine($"{darab}db páratlan szám van");
            */

            //min-max
            /*
            int[] tomb = new int[5];
            Random vsz = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(1, 21);
            }
            int max = tomb[0];
            int min = tomb[0];
            for (int i = 0;i < max; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
                
            Console.WriteLine($"Maximum: {max}, Minimum: {min}");
            */
            /*
            int[] tomb = new int[600];
            Random vsz = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(-1000, 1001);
            }
            int max = tomb[0];
            int min = tomb[0];
            for (int i = 0;i < max; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine($"Minimum: {min} Maximum: {max}");
            bool Vanbenne = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 245 || tomb[i] == -128)
                {
                    Vanbenne = true;
                    break;
                }
            }
            if (Vanbenne)
            {
                Console.WriteLine("Van benne 245 vagy -128");
            }
            else
            {
                Console.WriteLine("Nincs benne 245 vagy -128");
            }
            int paros = 0;
            int paratlan = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    paratlan++;
                }
            }
            Console.WriteLine($"Van benne {paros}db páros és {paratlan}db páratlan szám");
            */

            /*
            int[] tomb = new int[100000];
            Random vsz = new Random();
            long osszegzes = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(1000000, 3000000);
                osszegzes += tomb[i];
            }
            int min = tomb[0];
            int max = tomb[0];
            for (int i = 0;i < tomb.Length;i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            Console.Write($"Min: {min} Max: {max}");
            Console.WriteLine($"\nÖsszegzés: {osszegzes}");
            */

            // szétválogatás
            /*
            int[] aTomb = new int[100];
            int[] bTomb = new int[100];
            int[] cTomb = new int[100];
            int paratlan = 0;
            int paros = 0;
            Random vsz = new Random();
            for (int i = 0; i < aTomb.Length; i++)
            {
                aTomb[i] = vsz.Next(1, 1001);
            }
            for (int i = 0; i < aTomb.Length; i++)
            {
                if (aTomb[i] % 2 == 0)
                {
                    bTomb[paros] = aTomb[i];
                    paros++;
                }
                else
                {
                    cTomb[paratlan] = aTomb[i];
                    paratlan++;
                }
            }
            Console.WriteLine($"Párosok ({paros}db):");
            for (int i = 0; i < paros; i++)
            {
                Console.Write($"{bTomb[i]} ");
            }
            Console.WriteLine($"\nPáratlanok ({paratlan}db):");
            for (int i = 0; i < paratlan; i++)
            {
                Console.Write($"{cTomb[i]} ");
            }
            Console.WriteLine($"\nMindkettő tömb ({paros + paratlan}db):");
            for (int i = 0; i < aTomb.Length; i++)
            {
                Console.Write($"{aTomb[i]} ");
            }
            */


            // tömb feltöltés
            /*
            int[] tomb = new int[100];
            Random vsz = new Random();
            int osszeg = 0;
            int megszamolas = 0;
            bool vanBenne = false;
            int[] negativok = new int[100];
            int negativokIndex = 0;
            int[] negyharomOszt = new int[100];
            int szetvalIndex = 0;
            int[] maradek = new int[100];
            int maradekIndex = 0;
            int min = 0;
            int max = 0;
            Console.WriteLine($"Számok:");
            Console.WriteLine(" ");
            // összegzés
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(-100,101);
                osszeg += tomb[i];
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"A számok összege: {osszeg}");
            // eldöntés
            for (int i = 0;i < tomb.Length; i++)
            {
                if (tomb[i] == 0)
                {
                    vanBenne = true;
                    break;
                }
            }
            if (vanBenne)
            {
                Console.WriteLine("Van benne nulla");
            }
            else
            {
                Console.WriteLine("Nincs benne nulla");
            }
            // kiválasztás
            vanBenne = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 0)
                {
                    Console.WriteLine($"A nulla a tömb {i}. indexű helyén van");
                    vanBenne = true;
                }
            }
            // megszámolás
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 0)
                {
                    megszamolas++;
                }
            }
            Console.WriteLine($"{megszamolas}db van ebből a számból");
            // kiválogatás
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < 0)
                {
                    negativok[negativokIndex] = tomb[i];
                    negativokIndex++;
                }
            }
            Console.WriteLine("Negatív számok: ");
            for (int i = 0; i < negativokIndex; i++)
            {
                Console.Write($"{negativok[i]} ");
            }
            // szétválogatás
            Console.WriteLine("\nSzámok amik 3-mal és 4-el oszthatóak: ");
            for (int i = 0;i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0 && tomb[i] % 4 == 0)
                {
                    negyharomOszt[szetvalIndex] = tomb[i];
                    Console.Write($"{negyharomOszt[i]} ");
                }
                else
                {
                    maradek[maradekIndex] = tomb[i];
                    Console.Write($"{maradek[i]} ");
                }
            }
            // min-max
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                { 
                    min = tomb[i];
                }
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine($"\nMin: {min} Max: {max}");
            */

            // Tömb töltés
            int[] tomb = new int[140];
            Random vsz = new Random();
            bool vanBenne = false;
            int osszeg = 0;
            int darabszam = 0;
            int[] negativok = new int[140];
            int negativIndex = 0;
            int[] hattalOszt = new int[140];
            int hattalOsztIndex = 0;
            int min = 0;
            int max = 0;
            int[] maradek = new int[140];
            int maradekIndex = 0;
            double szorzat = 1;
            // Összegzés
            Console.WriteLine("Számok: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(-5, 121);
                osszeg += tomb[i];
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine($"\nÖsszeg: {osszeg}");
            // Eldöntés
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 110)
                {
                    vanBenne = true;
                    break;
                }
            }
            if (vanBenne)
            {
                Console.WriteLine("Van benne 110");
            }
            else
            {
                Console.WriteLine("Nincs benne 110");
            }
            // Kiválasztás
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 21)
                {
                    Console.WriteLine($"A 21-es a lista {i}. indexű helyén van");
                }
            }
            // Darabszám
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 108)
                {
                    darabszam++;
                }
            }
            Console.WriteLine($"{darabszam}db 108-as van.");
            // Kiválogatás
            Console.WriteLine("Negatív számok: ");
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < 0)
                {
                    negativok[negativIndex] = tomb[i];
                    negativIndex++;
                }
            }
            if (negativIndex > 0)
            {
                for (int i = 0; i < negativIndex; i++)
                {
                    Console.Write($"{negativok[i]} ");
                }
            }
            // Szétválogatás
            Console.WriteLine("\nHattal oszthatóak:");
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 6 == 0)
                {
                    hattalOszt[hattalOsztIndex] = tomb[i];
                    hattalOsztIndex++;
                }
                else
                {
                    maradek[maradekIndex] = tomb[i];
                    maradekIndex++;
                }
            }
            if (hattalOsztIndex > 0)
            {
                for (int i = 0; i < hattalOsztIndex; i++)
                {
                    Console.Write($"{hattalOszt[i]} ");
                }
            }
            Console.WriteLine("\nHattal nem oszthatóak:");
            if (maradekIndex > 0)
            {
                for (int i = 0; i < maradekIndex; i++)
                {
                    Console.Write($"{maradek[i]} ");
                }
            }
            // Min-Max
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine($"\nMinimum: {min} Maximum: {max}");
            // Tömb elemeinek szorzata 
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != 0)
                {
                    szorzat = tomb[i] * szorzat;
                }
                else
                {
                    Console.WriteLine("Nullával nem lehet szorozni");
                    break;
                }
            }
            Console.WriteLine($"Számok szorzata: {szorzat}");
            Console.ReadKey();
        }
    }
}
