using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes_Portfolio_OBP
{
    //class ist als public gesetzt wheil wir brauchen unit tests machen
    public class Triangle
    {
        private int sideA;
        private int sideB;
        private int sideC;
        private Line[] lines = new Line[3];

       
        //custom constructor
        public Triangle(int a=3, int b=4, int c=5)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
            lines[0] = new Line(this.sideA);
            lines[1] = new Line(this.sideB);
            lines[2] = new Line(this.sideC);
        }

        //Umfang und Flache(Heronsche Formel) berechnen
        public int Tr_Perimeter()
        {
            int result = this.sideA + this.sideB + this.sideC;
            return result;
        }

        public double Tr_Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - this.sideA) * (s - this.sideB) * (s - this.sideC));

        }
    }
}
