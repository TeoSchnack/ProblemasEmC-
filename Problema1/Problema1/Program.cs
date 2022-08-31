/** Problema 1
*   --------------------------------------
*   Se listarmos todos os n?meros naturais abaixo de 10 que 
*   s?o m?ltiplos de 3 ou 5, obtemos 3, 5, 6 e 9. A soma desses
*   m?ltiplos ? 23.
*
*
*Encontre a soma de todos os m?ltiplos de 3 ou 5 abaixo de 1000.
**/
using System;

namespace Problema1
{
    class Program
    {
        static void Main( string[] args )
        {
            char Opt = Menu();

            while (Opt != '0')
            {
                Gap(10);

                if (Opt == '1')
                {
                    Resolvedor(10);
                }
                else if (Opt == '2')
                {
                    Resolvedor(1000);
                }
                else if (Opt == '3')
                {
                    Texto();
                }

                Gap(3);
                Opt = Menu();
            }
        }


        
        
        
        
        static char Menu ()
        {
            Console.WriteLine(" 1 | Exemplo");
            Console.WriteLine(" 2 | Problema");
            Console.WriteLine(" 3 | Texto do Problema");
            Console.WriteLine(" 0 | Sair");
            Console.WriteLine("Digite sua Opção:");
            return char.Parse(Console.ReadLine());
        }


        static void Resolvedor ( int _limite)
        {
            string Res = "";
            double Soma = 0;

            for ( int I = 0; I < _limite; I ++)
            {
                if (  I % 3 == 0 )
                {
                    Res += " --- " + I;
                    Soma += I;
                }
                else if ( I % 5 == 0 )
                {
                    Res += " --- " + I;
                    Soma += I;
                }
            }

            Res = Res.Substring(5);
            Console.WriteLine(Res + " = " + Soma);
        }
    

        static void Texto ()
        {
            Console.WriteLine("Problema 1");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Se listarmos todos os números naturais abaixo de 10 que");
            Console.WriteLine("são múltiplos de 3 ou 5, obtemos 3, 5, 6 e 9. A soma desses");
            Console.WriteLine("múltiplos = 23.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Encontre a soma de todos os múltiplos de 3 ou 5 abaixo de 1000.");
        }

        static void Gap ( int _ln )
        {
            for ( int I = 0; I < _ln; I++ )
            {
                Console.WriteLine();
            }
        }
    }
}