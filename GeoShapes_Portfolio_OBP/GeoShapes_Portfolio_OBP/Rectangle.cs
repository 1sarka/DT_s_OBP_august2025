using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes_Portfolio_OBP
{
    public class Rectangle
    {
        private int sideA;
        private int sideB;
        //array fur linien verbinden
        private Line[] lines = new Line[4];

        //construktor
        public Rectangle(int a = 2, int b = 3)
        {
            this.sideA = a;
            this.sideB = b;
            lines[0] = new Line(this.sideA);
            lines[1] = new Line(this.sideB);
            lines[2] = new Line(this.sideA);
            lines[3] = new Line(this.sideB);
        }

        //Umfang und Flache berechnen

        /// <summary>
        /// Berechnet den Umfang des aktuellen Objekts (this-Instanz).
        /// </summary>
        /// <returns>Der berechnete Umfang des Rechtecks.</returns>
        public int Rect_Perimeter() 
        {
            return 2*(sideA +  sideB);
        }


        /// <summary>
        /// Berechnet die Fläche des aktuellen Objekts (this-Instanz).
        /// </summary>
        /// <returns> Die berechnete Fläche des Rechtecks.</returns>
        public int Rect_Area()
        {
            return sideA * sideB;
        }

    }
}
