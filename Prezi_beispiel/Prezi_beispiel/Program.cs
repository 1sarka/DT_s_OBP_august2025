namespace Prezi_beispiel
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Digital Talents!");

            //inicialization of objects
            Person Frank = new Person("Frank","customer");
            /* string person1name = "frank";
             * int person1alter = 28;
             * string person1rolle = "customer";
             * ...
             * ...
             */

            Haus FranksHouse = new Haus();

            //use of the method from class
            Frank.SayHi();
            FranksHouse.BuildHouse(2025,"red",4 );

            //property anpasen
            Console.WriteLine(FranksHouse.RoomsNumber);
            FranksHouse.RoomsNumber = 10;
            Console.WriteLine(FranksHouse.RoomsNumber);

        }
    }
}
