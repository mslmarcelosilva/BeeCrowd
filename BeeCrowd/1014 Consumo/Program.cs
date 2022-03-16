using System;

namespace _1014_Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Exerício"
            /*
             Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).

Entrada
O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

Saída
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
             */
            #endregion
            double km, litro, consumo;
            litro = double.Parse(Console.ReadLine());
            km = double.Parse(Console.ReadLine());
            consumo = litro / km;
            Console.WriteLine($"{consumo.ToString("F3")} km/l");
        }
    }
}
