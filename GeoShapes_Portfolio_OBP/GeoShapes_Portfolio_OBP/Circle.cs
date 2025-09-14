using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes_Portfolio_OBP
{
    internal class Circle
    {
        //definiton von der Radius variable
        private int radius;
        //wheil es nur 1 linie gibt reicht auch normale variable = keine array oder list
        private Line line1;

        // construktor
        public Circle(int r = 5)
        {
            this.radius = r;
            line1 = new Line(2*Math.PI*radius);
        }

        //Umfang und Flache berechnen

        /// <summary>
        /// Berechnet den Umfang des aktuellen Kreises und gibt ihn zurück.
        /// </summary>
        /// <returns>Der berechnete Umfang des Kreises</returns>
        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }
        /// <summary>
        ///  Berechnet die Fläche des aktuellen Kreises (this-Instanz).
        /// </summary>
        /// <returns>Die berechnete Fläche des Kreises.</returns>
        public double Cr_Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
