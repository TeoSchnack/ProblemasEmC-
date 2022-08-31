/**Problema 3
*--------------------------------------
*   Os fatores primos de 13195 s?o 5, 7, 13 e 29.
*
*   Qualo maior fator primo do n?mero 600851475143?
**/
using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            char Opt = '5';
            
            while (Opt != '0')
            {
                Gap(10);

                if ( Opt == '1')
                {
                    Texto();
                }
                else if (Opt == '2')
                {
                    Resolvedor(13195);
                }
                else if (Opt == '3')
                {
                    Resolvedor(600851475143);
                }

                Gap(10);
                Opt = Menu();
            }
        }

        static void Resolvedor ( double Nd )
        {
            int Nt, Nm = 0;
            Console.WriteLine("Numero = " + Nd);

            for (int I = 2; I < Nd; I++)
            {
                Nt = 0;
                for (int E = 2; E <= I; E++)
                {
                    if (I % E != 0)
                    {
                        Nt++;
                    }
                    else if (I != E)
                    {
                        Nt = 0;
                        break;
                    }
                    else
                    {
                        Nt++;
                    }
                }

                if (Nt > 0)
                {
                    if (Nd % I == 0)
                    {
                        Nd /= I;

                        if (I > Nm)
                        {
                            Nm = I;
                        }
                    }

                    if (Nd == 0)
                    {
                        break;
                    }

                }
            }

            Console.WriteLine(Nm);
        }


        static char Menu ()
        {
            Console.WriteLine(" 1 | Texto do Problema");
            Console.WriteLine(" 2 | Exemplo");
            Console.WriteLine(" 3 | Problema");
            Console.WriteLine(" 0 | Sair");

            return char.Parse(Console.ReadLine());
        }

        static  void Gap ( int Ln )
        {
            for ( int I = 0; I < Ln; I ++ )
            {
                Console.WriteLine();
            }
        }

        static void Texto ()
        {
            Console.WriteLine("Problema 3");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Os fatores primos de 13195 são 5, 7, 13 e 29.");
            Console.WriteLine();
            Console.WriteLine("Qualo maior fator primo do número 600851475143 ?");
        }
    }
}