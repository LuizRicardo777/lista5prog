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
                    double soma = 0, num;
                    for (; soma <= 200;)
                    {
                        Console.WriteLine("entre com um numero");
                        num = double.Parse(Console.ReadLine());

                        if (num > 0)
                        {
                            soma += num;
                            Console.WriteLine("numero positivo " + num +
                                              " valor da soma atual " + soma);
                        }
                        else
                        {
                            Console.WriteLine("numero negativo");
                        }
                    }
                    Console.ReadKey();


                    break;

                case 5:

                    double nu;

                    Console.Write("Digite um número inteiro: ");
                    nu = double.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de " + nu + ":");

                    for (int i = 1; i <= nu; i++)
                    {
                        if (nu % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                        else
                        {
                            Console.WriteLine("este numero não é esperado, tente um inteiro");
                        }
                    }

                    break;

                case 6:

                    int maior = int.MinValue;
                    int menor = int.MaxValue;

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write("Digite o " + i + "º número: ");
                        int nm = int.Parse(Console.ReadLine());

                        if (nm > maior)
                        {
                            maior = nm;
                        }

                        if (nm < menor)
                        {
                            menor = nm;
                        }
                    }

            
                        
                    
            
                    Console.WriteLine("O maior número digitado foi: " + maior);
                    Console.WriteLine("O menor número digitado foi: " + menor);
                    Console.ReadKey();

                    break;

                    case 7:

                    int numero9, somaPares = 0, somaImpares = 0;

                    for (Console.Write("Digite um número (0 para sair): "), numero9= int.Parse(Console.ReadLine()); numero9 != 0; Console.Write("Digite um número (0 para sair): "), numero9 = int.Parse(Console.ReadLine()))
                    {
                        if (numero9 % 2 == 0)
                        {
                            somaPares += numero9;
                        }
                        else
                        {
                            somaImpares += numero9;
                        }
                    }

                    Console.WriteLine("Soma dos números pares: " + somaPares);
                    Console.WriteLine("Soma dos números ímpares: " + somaImpares);
                    Console.ReadKey();
                    break;



                default:
                    Console.WriteLine("esta opção não existe");
                    break;
           }




        }
    }
}
