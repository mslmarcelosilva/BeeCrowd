using System;

namespace _1013_O_Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Exercício"
            /*
             Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:



Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
             */
            #endregion
            int a, b, c, maior, resposta;

            string[] x = Console.ReadLine().Split(' ');
            a = int.Parse(x[0]);
            b = int.Parse(x[1]);
            c = int.Parse(x[2]);

            maior = (a + b + Math.Abs(a - b)) / 2;
            resposta = (maior + c + Math.Abs(maior - c)) / 2;
            Console.WriteLine(resposta + " eh o maior");
        }
    }
}
