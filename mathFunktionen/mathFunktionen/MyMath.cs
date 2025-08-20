using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathFunktionen
{
    internal class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z = 0;
            while (b != 0)
            {
                    z = a % b;
                    a = b;
                    b = z;    
            }
            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            a = (a*b) / Calc_ggT(a, b);
            return a;
        }

        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Calc_ggT_r(b, a % b);
           
        }

        //aufgabe 8 funktionen
        public static double MittelWert(int[] numbers)
        {
            
            int sum = 0;
            foreach(int n in numbers)
            { 
                sum = sum + n;
            }
            return sum/numbers.Length;
        }

        public static int kleinsterWert(int[] nummbers)
        {
            int klein = int.MaxValue;
            foreach (int n in nummbers)
            {
                if (n<klein)
                {
                    klein = n;
                }
            }
           return klein;
        }

        public static int maximalWert(int[] numbers)
        {
            int max = int.MinValue;
            foreach(int n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }
        
    }
}
