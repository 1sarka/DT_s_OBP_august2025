namespace Verein
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //in praxis ist erstelen von klassen abhangig von situation - "mann kann nicht sagen" ob von unten nach oben oder anderst herum
            //teda ako sa pise program zalezi musime naplanovat podla logiky


            Verein kruzok = new Verein("Kvetinky", "jozko mrkvicka");
            Manchaft TeamOne = new Manchaft("moto nemam hehehee", new List<string> { "tur", "123","234","345","456","567","678","789","891","910","101"}, new List<string> { "brankar","brankar2"});
        }
    }
}
