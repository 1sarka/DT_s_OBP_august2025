namespace Rekursion_beispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(FactorialRecursive(15));
        }

        public static int FactorialRecursive(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * FactorialRecursive(n - 1);
        }
    }
}
