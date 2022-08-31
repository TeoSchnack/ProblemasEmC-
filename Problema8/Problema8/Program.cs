/**Problema 8
*   ---------------------------------
*   Os quatro dígitos adjacentes no número de 
*   1000 dígitos que têm o maior produto são 9 × 9 × 8 × 9 = 5832.
* 
*   Encontre os treze dígitos adjacentes no número de 1000 dígitos 
*   que têm o maior produto. Qual o valor deste produto? 
 **/
using System;

namespace Problema8
{
    class Program
    {
        public static string NG = "731671765313306249192251196744265747423553491949349698320312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        
        static void Main(string[] args)
        {
            char Opt = '5';
            
            while ( Opt != '0')
            {

                Gap(10);

                if (Opt == '1')
                {
                    Problema();
                }
                else if (Opt == '2')
                {
                    Resolvedor(4);
                }
                else if (Opt == '3')
                {
                    Resolvedor(13);
                }

                Gap(10);
                Opt = Menu();
            }
        }

        static void Resolvedor (int N)
        {
            string Ncg = NG, Naux, Nmax = "";
            int[] Num = new int[N];
            int Nmult, Nmmax = 0;


            while (Ncg.Length > N)
            {
                Naux = Ncg.Substring(0, N);
                Ncg = Ncg.Substring(1);
                Nmult = 1;
                for (int I = 0; I < N; I++)
                {
                    Num[I] = int.Parse(Naux.Substring(0, 1));
                    Nmult *= Num[I];
                    Naux = Naux.Substring(1, (Naux.Length - 1));
                }

                if (Nmult > Nmmax)
                {
                    Nmax = "";

                    for (int I = 0; I < N; I++)
                    {
                        Nmax += Num[I] + " * ";
                    }

                    Nmax = Nmax.Substring(0, (Nmax.Length - 3)) + " = " + Nmult;
                    Nmmax = Nmult;
                }
            }

            Console.WriteLine(Nmax);
        }

        static void Problema ()
        {
            Console.WriteLine("Problema 8");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Os quatro dígitos adjacentes no número de");
            Console.WriteLine("1000 dígitos que têm o maior produto são 9 × 9 × 8 × 9 = 5832.");
            Console.WriteLine();
            Console.WriteLine("Encontre os treze dígitos adjacentes no número de 1000 dígitos");
            Console.WriteLine("que têm o maior produto. Qual o valor deste produto ?");


        }

        static char Menu ()
        {
            Console.WriteLine(" 1 | Texto do Problema");
            Console.WriteLine(" 2 | Exemplo");
            Console.WriteLine(" 3 | Problema Resolvido");
            Console.WriteLine(" 0 | Sair");

            return char.Parse(Console.ReadLine());
        }

        static void Gap (int Ln)
        {
            for ( int I = 0; I < Ln; I++ )
            {
                Console.WriteLine();
            }
        }
    }
}