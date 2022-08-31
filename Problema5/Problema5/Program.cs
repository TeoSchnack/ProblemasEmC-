/**Problema 5
*   --------------------------------------
*   2520 ? o menor n?mero que pode ser dividido por 
*   cada um dos n?meros de 1 a 10 sem deixar resto.
*
*   Qual ? o menor n?mero positivo que ? divis?vel 
*   por todos os n?meros de 1 a 20?  
**/
using System;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            char Opt = '5';

            while ( Opt != '0')
            {
                Gap(10);

                if ( Opt == '1')
                {
                    Problema();
                }
                else if (Opt == '2')
                {
                    Resolvedor(10);
                }
                else if (Opt == '3')
                {
                    Resolvedor(20);
                }

                Gap(10);
                Opt = Menu();
            }
        }

        static void Resolvedor (int Nm)
        {
            int I, E, T = 0;

            for (I = Nm; I < 10000000000000; I++)
            {
                for (E = 1; E <= Nm; E++)
                {
                    if (I % E == 0)
                    {
                        T++;
                    }
                    else
                    {
                        T = 0;
                        break;
                    }
                }

                if (T == (E - 1))
                {
                    break;
                }
            }

            Console.WriteLine(I);
        }

        static void Problema()
        {
            Console.WriteLine("Problema 5");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("2520 é o menor número que pode ser dividido por");
            Console.WriteLine("cada um dos números de 1 a 10 sem deixar resto.");
            Console.WriteLine();
            Console.WriteLine("Qual é o menor número positivo que é divisível");
            Console.WriteLine("por todos os números de 1 a 20 ?");
        }

        static char Menu ()
        {
            Console.WriteLine(" 1 | Texto do Problema");
            Console.WriteLine(" 2 | Exemplo");
            Console.WriteLine(" 3 | Problema Resolvido");
            Console.WriteLine(" 0 | Sair");

            return char.Parse(Console.ReadLine());
        }

        static void Gap( int Ln )
        {
            for ( int I = 0; I < Ln; I++ )
            {
                Console.WriteLine();
            }
        }
    }
}