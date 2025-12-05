namespace factorial_repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));

            
        }
        public static uint Factorial(uint n)
        {
            if(n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
