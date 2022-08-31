/** Problema 2
*   --------------------------------------
*   Cada novo termo na sequencia de Fibonacci ? gerado pela adi??o 
*   dos dois termos anteriores. Come?ando com 1 e 2, os 10 primeiros 
*   termos ser?o:
*
*               1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
*
*   Considerando os termos da sequencia de Fibonacci cujos valores n?o 
*   excedem quatro milhares, encontre a soma dos termos de valor par.
**/
using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            char Opt = '5';

            while (Opt != '0')
            {
                Gap(10);

                if (Opt == '1')
                {
                    Texto();
                }
                else if ( Opt == '2')
                {
                    Resolvedor(10);
                }
                else if(Opt == '3' )
                {
                    Resolvedor(4000000);
                }

                Gap(10);
                Opt = Menu();
            }
            
        }


        
        static void Resolvedor ( int Max )
        {
            int N1 = 1, N2 = 2, N3 = 0, Par = 0;
            Console.Write(N1 + " ");


            while (N3 < Max)
            {
                N3 = N1 + N2;
                Console.Write(N3 + " ");
                N1 = N2;
                N2 = N3;

                if (N1 % 2 == 0)
                {
                    Par += N3;
                }
            }

            Console.WriteLine(Par);
        }

        static char Menu ()
        {
            Console.WriteLine(" 1 | Texto do Problema");
            Console.WriteLine(" 2 | Exemplo");
            Console.WriteLine(" 3 | Problema");
            Console.WriteLine(" 0 | Sair");

            return char.Parse(Console.ReadLine());
        }
        
        static void Gap (int _ln)
        {
            for (int I = 0; I < _ln; I++)
            {
                Console.WriteLine();
            }
        }

        static void Texto ()
        {
            Console.WriteLine("Problema 2");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Cada novo termo na sequencia de Fibonacci é gerado pela adição");
            Console.WriteLine("dos dois termos anteriores.Come? ando com 1 e 2, os 10 primeiros");
            Console.WriteLine("termos ser? o:");
            Console.WriteLine();
            Console.WriteLine("1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...");
            Console.WriteLine();
            Console.WriteLine("Considerando os termos da sequencia de Fibonacci cujos valores n? o");
            Console.WriteLine("excedem quatro milhares, encontre a soma dos termos de valor par.");
        }
    }
}