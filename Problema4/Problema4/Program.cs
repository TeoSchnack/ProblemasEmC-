/**Problema 4
*   --------------------------------------
*   Um n?mero palindr?mico l? da mesma forma nos dois sentidos. 
*   O maior palindr?mico feito do produto de dois n?meros de 2 
*   d?gitos ? 9009 = 91 ? 99.
*
*   Encontre o maior palindr?mico feito do produto de dois 
*   n?meros de 3 algarismos.
**/
using System;

namespace Problema4
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
                    Problema();
                }
                else if (Opt == '2')
                {
                    Resolvedor(99);
                }
                else if (Opt == '3')
                {
                    Resolvedor(999);
                }

                Gap(10);
                Opt = Menu();
            }
        }

            static void Resolvedor(int N)
            {
                bool T = false;
                int I = 0, E = 0;
                string Res = "", Inv, Aux;

                for (I = N; I > 0; I--)
                {
                    for (E = N; E > 0; E--)
                    {
                        Res = E * I + "";
                        Inv = "";
                        Aux = Res;

                        for (int U = 0; U < Res.Length; U++)
                        {
                            Inv += Aux.Substring((Aux.Length - 1));
                            Aux = Aux.Substring(0, (Aux.Length - 1));
                        }

                        if (Inv.Equals(Res))
                        {
                            T = true;
                            break;
                        }
                    }

                    if (T)
                    {
                        break;
                    }
                }

                Console.WriteLine(I + " * " + E + " = " + Res);
            }

            static void Problema()
            {
                Console.WriteLine("Problema 4");
                Console.WriteLine(" --------------------------------------");
                Console.WriteLine("Um número palindrimico lido da mesma forma nos dois sentidos.");
                Console.WriteLine("O maior palindrimico feito do produto de dois números de 2");
                Console.WriteLine("dígitos é 9009 = 91 * 99.");
                Console.WriteLine();
                Console.WriteLine("Encontre o maior palindrimico feito do produto de dois");
                Console.WriteLine("números de 3 algarismos.");
            }

            static char Menu()
            {
                Console.WriteLine(" 1 | Texto do Problema");
                Console.WriteLine(" 2 | Exemplo");
                Console.WriteLine(" 3 | Resolvido");
                Console.WriteLine(" 0 | Sair");

                return char.Parse(Console.ReadLine());
            }

            static void Gap(int Ln)
            {
                for (int I = 0; I < Ln; I++)
                {
                    Console.WriteLine();
                }
            }
    }
}