using System;
using System.Globalization;

namespace _1012_Área
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Exercício"
            /*
             * screva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
             */
            #endregion
            double a, b, c, tRetangulo, circulo, trapezio, quadrado, retangulo, pi;
            pi = 3.14159;

            string[] x = Console.ReadLine().Split(' ');
            a = double.Parse(x[0]);
            b = double.Parse(x[1]);
            c = double.Parse(x[2]);

            tRetangulo = a * c / 2;
            circulo = pi * Math.Pow(c, 2);
            trapezio = (a + b) * c / 2;
            quadrado = b * b;
            retangulo = a * b;


            Console.WriteLine($"TRIANGULO: {tRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
