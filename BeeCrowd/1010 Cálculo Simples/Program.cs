using System;
using System.Globalization;

namespace _1010_Cálculo_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
             * Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
             */
            #endregion

            int codigo1, codigo2, qtde1, qtde2;
            double preco1, preco2, resultado1, resultado2, total;

            string[] pedido1 = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(pedido1[0]);
            qtde1 = int.Parse(pedido1[1]);
            preco1 = double.Parse(pedido1[2]);
            resultado1 = qtde1 * preco1;

            string[] pedido2 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(pedido2[0]);
            qtde2 = int.Parse(pedido2[1]);
            preco2 = double.Parse(pedido2[2]);
            resultado2 = qtde2 * preco2;
            total = resultado1 + resultado2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
