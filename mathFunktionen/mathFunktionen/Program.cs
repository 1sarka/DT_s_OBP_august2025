using System.Runtime.InteropServices;

namespace mathFunktionen
{
    internal class Program
    {
        //domaca uloha - bod 8 array - hausaufabe 7 - precitat mikrosoft array
        static void Main(string[] args)
        {
            int resultat_ggT = MyMath.Calc_ggT(3, 18);
            int[] numbers = new int[5];

            string aktion = "y";
            while(aktion == "y" || aktion == "Y")
            {
                Console.WriteLine("bitte schreib mit welche operation willst du berechnen \n benutze genaue abkurtzung sont funktioniert es nicht:");
                Console.WriteLine(" -'kgV'\n -'ggT'\n -'ggT_r' \n Operationen mit array: \n -'max' \n - 'min' \n - 'avg' ");
                string operation = Console.ReadLine().ToLower();
                if(operation == "kgv" || operation == "ggt" || operation == "ggt_r" || operation == "array_ops")
                {

                    
                    int erstezahl = ReadInt();
                    int zweitezahl = ReadInt();
                  
                   
                    if(operation == "kgv")
                    {
                       ShowResult(operation, erstezahl, zweitezahl, MyMath.Calc_kgV(erstezahl, zweitezahl));
                    }
                    else
                    {
                        if(operation == "ggt")
                        {
                            ShowResult(operation, erstezahl, zweitezahl, MyMath.Calc_ggT(erstezahl, zweitezahl));
                        }
                        else
                        {
                            if(operation == "array_ops")
                            {
                                Console.WriteLine("array ist mit 5 zahlen limitiert - mogliche operationen: \n - 'max' \n - 'min' \n - 'avg' ");
                               string op2 = Console.ReadLine().ToLower();
                                int[] nummers = ReadValues(5);
                                if (op2 == "max")
                                {
                                    ShowResult2(op2, nummers, MyMath.maximalWert(nummers));
                                }
                                else
                                {
                                    if(op2 == "min")
                                    {
                                        ShowResult2(op2, nummers, MyMath.kleinsterWert(nummers));
                                    }
                                    else
                                    {
                                        if(op2 == "avg")
                                        {
                                            ShowResult2(op2, nummers, MyMath.MittelWert(nummers));
                                        }
                                        else
                                        {
                                            Console.WriteLine("falsches eingabe");
                                        }
                                    }
                                }

                            }
                            else
                            {
                            ShowResult(operation, erstezahl, zweitezahl, MyMath.Calc_ggT_r(erstezahl, zweitezahl));
                            }
                        }
                       
                    }
                }
                else
                {
                    Console.WriteLine("du hast schlechtes input eingegeben.");
                }
                 Console.WriteLine("du kannst program beenden oder eine neu versuch mit drucken taste 'y' starten:");
                 aktion = Console.ReadLine();

            }


        }

        public static int ReadInt()
        {
            int zahl = 0;
            do
            {
                Console.WriteLine("bitte eine ganze zahl eineben ()");
                string s = Console.ReadLine();
                int.TryParse(s, out zahl);

            } while (zahl <= 0);

            return zahl;
        }

        public static void ShowResult(string mathop, int a,int b, int result)
        {
            Console.WriteLine($"{mathop} von {a} und {b} ist {result}");
        }

        public static void ShowResult2(string op2, int[] nummers, double arrop)
        {
            foreach (int n in nummers)
            {

            }
            Console.WriteLine($"{op2} von array {nummers} ist {arrop}");
        }

        public static int[] ReadValues(int anzahl)
        {
            int i = 0;
            int[] werte = new int[anzahl];
            while (i<anzahl)
            {
                werte[i++]= ReadInt();
            }
            return werte;
        }
        public static bool IsOpValid(string op)
        {
            return (op == "max" || op == "min" || op == "avg" || op == "kgv" || op == "ggt" || op == "ggt_r");
        }

    }
}
