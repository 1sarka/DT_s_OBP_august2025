namespace faktoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chyba = problem iba 2 results ak by bol result viac ako z 2 cisel neni osetrene = preto treba liste pouzit
            int result1 = 0;
            int result2 = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < x; i++)
            {
                if((x%i == 0 ) && ((x/i)%10 != 0))//(x/i != 10)nefunguje chyba mi overenie ci je delene 10
                {
                    result1 = x / i; 
                    result2 = i;
                    break;
                }
            }
            if( result1 == 0 )
            {
                Console.WriteLine("deine zahl ist eine primzahl");
            }
            else
            {
                Console.WriteLine($"deine zahlen sind: {result1} und {result2}");
            }

        }
    }
}
