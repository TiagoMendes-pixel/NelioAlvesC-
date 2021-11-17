using System;
using System.Globalization;

namespace ListaDeExerciciosLogicaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos*/

            Console.WriteLine("Digite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine($" A soma entre {n1} e {n2} é {soma}");

            ------------------------------------------------------------------------------------------------
            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
             casas decimais conforme exemplos.
             Fórmula da área: area = π.raio2
             Considere o valor de π = 3.14159*/

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine($" A aree é de {area.ToString("F4", CultureInfo.InvariantCulture)}");

            /* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
                de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */
            int A, B, C, D, difABCD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            difABCD = (A * B - C * D);

            Console.WriteLine($"O resultado é: {difABCD}");

            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.*/

            int func, horas;
            double valorTot, valor;

            func = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorTot = horas * valor;


            Console.WriteLine(" NUMBER: {0}", func);
            Console.WriteLine(valorTot.ToString("F2", CultureInfo.InvariantCulture));


            /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/

            int codPeca1, codPeca2, numpecas1, numpecas2;
            double valorPeca1, valorPeca2, valorTot1, valorTot2, valorTotal;

            codPeca1 = int.Parse(Console.ReadLine());
            codPeca2 = int.Parse(Console.ReadLine());
            numpecas1 = int.Parse(Console.ReadLine());
            numpecas2 = int.Parse(Console.ReadLine());
            valorPeca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorTot1 = numpecas1 * valorPeca1;
            valorTot2 = numpecas2 * valorPeca2;
            valorTotal = valorTot1 + valorTot2;

            Console.WriteLine($" O valor total é de {valorTotal.ToString("F2")}...");
            /*----------------------------------------------------------------------------------------*/
            Same exercise from above, using arrays though this time
            /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/


                int cod1, numPecas1;
            int cod2, numPecas2;
            double valorPeca1, valorPeca2, valorTot;

            string[] vet1 = (Console.ReadLine().Split(" "));
            string[] vet2 = (Console.ReadLine().Split(" "));


            cod1 = int.Parse(vet1[0]);
            numPecas1 = int.Parse(vet1[1]);
            valorPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            cod2 = int.Parse(vet2[0]);
            numPecas2 = int.Parse(vet2[1]);
            valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valorTot = (numPecas1 * valorPeca1) + (numPecas2 * valorPeca2);

            Console.WriteLine($"Os códigos da peça 1 é {cod1}. O código da peça 2 é {cod2}. O valor total das peças é R${valorTot.ToString("F2", CultureInfo.InvariantCulture)} ");

            ---------------------------------------------------------------------------------------
            /*Ultimo exercício dessa série
             Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.*/

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            circulo = 3.14159 * Math.Pow(C, 2);
            trapezio = (A + B) * C / 2;
            quadrado = Math.Pow(B, 2);
            retangulo = B * A;

            Console.WriteLine($"Triangulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}, Círculo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}, Trapezio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}, Quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}, Retangulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");











        }
    }
}
