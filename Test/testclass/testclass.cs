using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Functions
{
    public class FunctionService
    {
        public bool IsValidGrade(int grade)
        {
            return grade >= 1 && grade <= 5;
        }
        public string HosszabbSzo(string s1, string s2)
        {
            if (s1.Length > s2.Length) return s1;
            if (s2.Length > s1.Length) return s2;
            return "egyformák";
        }
        public bool BoltNyitva(int ora)
        {
            return ora >= 8 && ora <= 16;
        }
        public bool VanNegativ(int[] tomb)
        {
            foreach (int x in tomb)
                if (x < 0) return true;
            return false;
        }
        public string CsereMaganhangzo(string s)
        {
            string maganhangzok = "aáeéiíoóöőuúüűAÁEÉIÍOÓÖŐUÚÜŰ";
            string eredmeny = "";

            foreach (char c in s)
            {
                if (maganhangzok.Contains(c))
                    eredmeny += ".";
                else
                    eredmeny += c;
            }

            return eredmeny;
        }
        public int TeglalapKerulet(int a, int b)
        {
            return 2 * (a + b);
        }
    }
}