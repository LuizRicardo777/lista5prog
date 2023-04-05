using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lista5prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  ati;
            Console.WriteLine("ESCOLA SEU EXERCICIO");
            Console.WriteLine("EXERCICIO 1");
            Console.WriteLine("EXERCICIO 2");
            Console.WriteLine("EXERCICIO 3");
            Console.WriteLine("EXERCICIO 4");
            Console.WriteLine("EXERCICIO 5");
            Console.WriteLine("EXERCICIO 6");
            Console.WriteLine("EXERCICIO 7");

            ati = int.Parse(Console.ReadLine());
            switch (ati)
            {
                case 1:
                    int n;
                    n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("valor = " + i);
                        Thread.Sleep(500);

                    }
                    Console.ReadKey();
                    break;

                    case 2:
                    int n1;
                    Console.WriteLine("digite um numero");
                    n1 = int.Parse(Console.ReadLine());
                    for (int i = 1; i < n1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("valor  = " + i);
                            Thread.Sleep(100);
                        }
                    }

                    Console.ReadKey();
                    break;

                case 3:
                    int n2;
                    Console.WriteLine("digite um numero menor que 1000");
                    n2 = int.Parse(Console.ReadLine());

                    if (n2 > 1000)
                    {

                        Console.WriteLine("este não era o objetivo do programa");
                    }
                    else
                    {
                        for (int i = 1000; i >= n2; i--)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine("valor  = " + i);
                                Thread.Sleep(100);
                            }


                        }
                    }
                    Console.ReadKey();
                    break;

                case 4:
                      double soma = 0 ,num;
                    for (; soma <= 200;)
                    {
                        Console.WriteLine("entre com um numero");
                        num = double.Parse(Console.ReadLine());

                        if (num > 0)
                        {
                            soma += num;
                            Console.WriteLine("numero positivo " + num +
                                              " valor da soma atual " + soma );
                        }
                        else
                        {
                            Console.WriteLine("numero negativo");
                        }
                    }
                    Console.ReadKey();


                    break;

                case 5:





                    break;

                default:
                    break;

            }




           


















        }
    }
}
