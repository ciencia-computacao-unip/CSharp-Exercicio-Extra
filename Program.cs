using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordem
{
    static class Program
    {
        static void Main(string[] args)
        {
            int quantidade_numeros = 3;//define a quantidade de números a pegar
            int[] numeros = new int[quantidade_numeros];//define o array com $quantidade_numeros de itens
            string ordem; //define a variável de ordem

            for (int i = 1; i <= quantidade_numeros; i++){
                Console.Write("Digite o "+i+"º número:");
                numeros[i-1] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nOrdem Crescente ou Decrescente? ");
            ordem = Console.ReadLine().ToLower();
            if (ordem == "decrescente"){
                numeros = numeros.OrderByDescending(c => c).ToArray();
            }
            else if (ordem == "crescente"){
                Array.Sort(numeros);
            }else{
                Console.WriteLine("Erro. Digite crescente ou decrescente.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            for (int i = 1; i <= quantidade_numeros; i++){
                Console.WriteLine(numeros[i - 1]);
            }
            Console.ReadKey();

        }
    }
}
