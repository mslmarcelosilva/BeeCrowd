using System;

namespace _1018_Cédulas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
             Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
             */
            #endregion
            int resto, quociente, entrada, calculo;
            int[] nota = { 100, 50, 20, 10, 5, 2, 1 };
            entrada = int.Parse(Console.ReadLine());
            calculo = entrada;

            Console.WriteLine(entrada);
            for (int i = 0; i < 7; i++)
            {
                quociente = calculo / nota[i];
                resto = calculo % nota[i];
                Console.WriteLine(quociente + " nota(s) de R$ " + nota[i].ToString("F2"));
                calculo = resto;
            }
        }
    }
}
