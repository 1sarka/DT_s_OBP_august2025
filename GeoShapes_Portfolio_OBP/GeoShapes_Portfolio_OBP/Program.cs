namespace GeoShapes_Portfolio_OBP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test objekte
            Rectangle testRect = new Rectangle(5, 8);
            Console.WriteLine($"testing rectangle was created:\n his Area is: {testRect.Rect_Area()}\n his perimeter is: {testRect.Rect_Perimeter()}");
            Triangle testTriangle = new Triangle(4,5,6);
            Console.WriteLine($"testing triangle was created:\n his Area is: {testTriangle.Tr_Area()}\n his perimeter is: {testTriangle.Tr_Perimeter()}");
            Circle testCircle = new Circle();
            Console.WriteLine($"testing circle was created:\n his Area is: {testCircle.Cr_Area()}\n his circumference is: {testCircle.Circumference()}");

            //eine instanzierte formenbehalter
            Console.WriteLine();
            ShapeContainer container = new ShapeContainer(new Rectangle[] { new Rectangle(2, 3), new Rectangle(4, 5) },new List<Circle> { new Circle(6), new Circle() }, new List<Triangle> { new Triangle() });

            container.ContainerSummary();


        }
    }
}
