using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathFunktionen
{
    public class MyMath
    {
        /// <summary> toto sa vola xml doc - da s ato aj exportovat
        /// nieco zmysluplne co popisuje funkciu 
        /// </summary>
        /// <param name="a">popisujeme parametre - napr a erste zahl</param>
        /// <param name="b"> zeweite zahl</param>
        /// <returns>  groste gemeinshame teilbar value</returns>
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
        /// <summary>
        /// zahlt kleinste gemeinsahme teiler von zwei zahlen
        /// </summary>
        /// <param name="a">erste zahl</param>
        /// <param name="b">zweite zahl</param>
        /// <returns></returns>
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

        /// <summary>
        /// it counts average of array of numbers
        /// </summary>
        /// <param name="numbers">array of numbers</param>
        /// <returns>returns average</returns>
        public static double MittelWert(int[] numbers)
        {
            
            int sum = 0;
            foreach(int n in numbers)
            { 
                sum = sum + n;
            }
            return sum/numbers.Length;
        }
        /// <summary>
        /// it compare numbers and return the smales nummber from array
        /// </summary>
        /// <param name="nummbers">array of nummber</param>
        /// <returns>it returns the smallest nummber</returns>
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
