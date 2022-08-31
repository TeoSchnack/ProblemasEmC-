/**Problema 7
*   ---------------------------------
*   Ao listar os seis primeiros números primos: 
*   2, 3, 5, 7, 11 e 13, podemos ver que o 6º primo é 13.
*
*   Qual é o 10.001º número primo?
**/

using System;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            char Opt = '5';

            while ( Opt != '0' )
            {
                Gap(10);

                if ( Opt == '1' )
                {
                    Problema();
                }
                else if (Opt == '2')
                {
                    Resolvedor(6);
                }
                else if (Opt == '3')
                {
                    Resolvedor(10001);
                }

                Gap(10);
                Opt = Menu();
            }
        }

        static void Resolvedor ( int Nmax )
        {
            double I = 2, E;
            int cont = 0, Nt;
            string Res = "";

            while (cont < Nmax)
            {
                Nt = 0;
                for (E = 2; E <= I; E++)
                {

                    if (I % E != 0)
                    {
                        Nt = 1;
                    }
                    else if (I == E)
                    {
                        Nt = 1;
                    }
                    else
                    {
                        Nt = 0;
                        break;
                    }

                }


                if (Nt > 0)
                {
                    Res += I + " --- ";
                    cont += 1;
                }



                I += 1;
            }

            Res = Res.Substring(0, (Res.Length - 5));
            Console.WriteLine(Res);
        }

        static char Menu ()
        {
            Console.WriteLine(" 1 | Texto do Problema");
            Console.WriteLine(" 2 | Exemplo");
            Console.WriteLine(" 3 | Problema Resolvido");
            Console.WriteLine(" 0 | Sair");

            return char.Parse(Console.ReadLine());
        }

        static void Gap ( int Ln )
        {
            for ( int I = 0; I < Ln; I++ )
            {
                Console.WriteLine();
            }
        }

        static void Problema ()
        {
            Console.WriteLine("Problema 7");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ao listar os seis primeiros números primos: ");
            Console.WriteLine("2, 3, 5, 7, 11 e 13, podemos ver que o 6º primo é 13.");
            Console.WriteLine();
            Console.WriteLine("Qual é o 10.001º número primo ?");
        }
    }
}