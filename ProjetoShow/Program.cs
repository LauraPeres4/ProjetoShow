using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoShow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double meia = 0;
            double inteira = 0;
            {
                for (int i = 1; i <= 30; i++)
                {
                    Console.WriteLine("O comprador é estudante?[S/N]");
                    string comprador = Console.ReadLine().ToUpper();

                    if (comprador == "S" && i <= 10)
                    {
                        total = 50;
                        Console.WriteLine("O preço do ingresso neste primeiro lote é de: " + total);
                        total++;
                        meia += 1;
                    }
                    else
                    {
                        total = 100;
                        Console.WriteLine("O preço do ingresso será: " + total);
                        total++;
                        inteira += 1;
                    }
                    if (comprador == "S" && i <= 20)
                    {
                        total = 75;
                        Console.WriteLine("O preço do ingresso será de: " + total);
                        total++;
                        meia += 1;
                    }
                    else
                    {
                        total = 150;
                        Console.WriteLine("O preço do ingresso será de: " + total);
                        total++;
                        inteira += 1;
                    }
                    if (comprador == "S" && i <= 30)
                    {
                        total = 100;
                        Console.WriteLine("O preço do ingresso será de: " + total);
                        total++;
                        meia += 1;
                    }
                    else
                    {
                        total = 200;
                        Console.WriteLine("O preço do ingresso será de: " + total);
                        total++;
                        inteira += 1;
                    }
                    
                   
                   
                }
                Console.WriteLine("O valor arrecadado foi de: " + total);
                Console.WriteLine("A quantidade de meias entradas foi de: " + meia);
                Console.WriteLine("A quantidade de ingresso inteiros foi de: " + inteira);
            }

            Console.ReadKey();



        }
    }
}
