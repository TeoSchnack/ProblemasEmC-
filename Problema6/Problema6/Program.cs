/**Problema 6
*   ---------------------------------
*   A soma dos quadrados dos dez primeiros números naturais é,
*
*   O quadrado da soma dos dez primeiros números naturais é,
*
*   Portanto, a diferença entre a soma dos quadrados dos dez 
*   primeiros números naturais e o quadrado da soma é.
*
*   Encontre a diferença entre a soma dos quadrados dos primeiros 
*   cem números naturais e o quadrado da soma.
**/
using System;

namespace Problema6
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
                else if ( Opt == '2' )
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

        static void Resolvedor(int Ln)
        {

            double N1 = 0, N2 = 0, N3;

            for (double I = 0; I <= Ln; I++)
            {
                N1 += I;
                N2 += Math.Pow(I, 2);
            }

            N1 = Math.Pow(N1, 2);

            N3 = N1 - N2;

            Console.WriteLine(N3);
        }

        static void Problema()
        {
            Console.WriteLine("Problema 6");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("A soma dos quadrados dos dez primeiros números naturais é,");
            Console.WriteLine();
            Console.WriteLine("O quadrado da soma dos dez primeiros números naturais é,");
            Console.WriteLine();
            Console.WriteLine("Portanto, a diferença entre a soma dos quadrados dos dez");
            Console.WriteLine("primeiros números naturais e o quadrado da soma é.");
            Console.WriteLine();
            Console.WriteLine("Encontre a diferença entre a soma dos quadrados dos primeiros");
            Console.WriteLine("cem números naturais e o quadrado da soma.");
        }

        static void Gap ( int Ln )
        {
            for ( int I = 0; I < Ln; I++ )
            {
                Console.WriteLine();
            }
        }

        static char Menu()
        {
            Console.WriteLine(" 1 | Texto Problema");
            Console.WriteLine(" 2 | Exemplo");
            Console.WriteLine(" 3 | Problema Resolvido");
            Console.WriteLine(" 0 | Sair");

            return char.Parse(Console.ReadLine());
        }

    }
}