namespace arrays_exampel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4];
            int[] array2 = { 1, 2, 3 };
            Console.WriteLine(num.Length);
            Console.WriteLine(array2.Length);
            String[] array3 = { "hallo", "welt", "heute", "morgen", "schoone", "scheise", "ist","tag" };
            Console.WriteLine(array3[0] + array3[1] + array3[3] + array3[array3.Length-2]+ array3[4] +array3[array3.Length - 1]);
        
            for(int i = 0;i< array2.Length ;i++)
                {
                Console.WriteLine("jeeej");
                }

            foreach (int numer in num)
            {
                Console.WriteLine(numer);
            }
            foreach (string wort in array3)
                { 
                Console.WriteLine(wort);
            }
        }
    }
}
