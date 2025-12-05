namespace multiplikation_rek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Hello, World!");
            //Console.WriteLine(Multiplikation(5,10));
            //Console.WriteLine(fibonacciI(2));
            Console.WriteLine(FibonacciRekursive(40));
        }

        static int Multiplikation(int a, int b){
  
            if (a==1){
                return b;
            }
            return b+Multiplikation(a-1, b);
        }
        public static long FibonacciRekursive(long len)
        {
            if (len == 1 || len == 2)
            {
                return 1;
            }
            return FibonacciRekursive(len - 1) + FibonacciRekursive(len - 2);
        }

        public static long fibonacciI(int len)
        {
            long fib = 1;
            long zahl2 = 1;
            long zahl1 = 1;
            for (int i = 1; i < len-1; i++)
            {
                fib = zahl1 + zahl2;
                zahl1 = zahl2;
                zahl2 = fib;
            }
            return fib;
        }

    }
}
