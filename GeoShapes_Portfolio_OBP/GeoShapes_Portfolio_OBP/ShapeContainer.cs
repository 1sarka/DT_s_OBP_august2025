using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes_Portfolio_OBP
{
    internal class ShapeContainer
    {
        private Rectangle[] rectangles = new Rectangle[2] {new Rectangle(), new Rectangle(5,6)};
        private List<Circle> circels = new List<Circle> { new Circle()};
        private List<Triangle>? triangles; //? erlaubt auch null wert - whiel in formenbehalter muss keine dreieck sein
      
        public ShapeContainer(Rectangle[] rectangles, List<Circle> circels, List<Triangle> triangles)
        {
            if(rectangles.Length == 2)
            {
                this.rectangles = rectangles;
            }
            else
            {
                Console.WriteLine("Your input for Rectangle is invalid; I’ll use the default/predefined value.");
            }
            if (circels.Count >=1 && circels.Count<=3)
            {
                this.circels = circels;
            }
            else
            {
                Console.WriteLine("Your input for Circels is invalid; I’ll use the default/predefined value = one circle with radius 5.");
            }
            if(triangles.Count>=0 && triangles.Count <= 4)
            {
                this.triangles = triangles;
            }
            else
            {
                Console.WriteLine("Your input for Rectangle is invalid; I’ll use the default/predefined value. Predefines value is none triangle in shape container");
            }
        }
        /// <summary>
        /// Gibt in der Konsole eine Übersicht über die Anzahl von Rechtecken, Kreisen und Dreiecken im aktuellen ShapeContainer aus.
        /// </summary>
        public void ContainerSummary()
        {
            Console.WriteLine("In shape container you can find: ");
            Console.WriteLine($"{rectangles.Length} rectangles");
            Console.WriteLine($"{circels.Count} circle/s");
            Console.WriteLine($"{triangles?.Count} triangle/s");
        }
    }
}
