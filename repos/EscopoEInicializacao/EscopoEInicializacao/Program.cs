using System;
using System.Globalization;


namespace EscopoEInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            ////seguir, calcule e mostre o valor da conta a pagar.
            // Console.WriteLine("Digite o código do produto e a quantidade");
            //string[] valores = Console.ReadLine().Split(' ');
            //int cod = int.Parse(valores[0]);
            //int quantidade = int.Parse(valores[1]);


            ////condições do codigo com os preços
            //double precoTot = 0;
            //if (cod == 1)
            //{
            //    precoTot = quantidade * 4.00;
            //}
            //else if (cod == 2)
            //{
            //    precoTot = quantidade * 4.50;

            //}
            //else if (cod == 3)
            //{
            //    precoTot = quantidade * 5.00;

            //}
            //else if (cod == 4)
            //{
            //    precoTot = quantidade * 2.00;

            //}
            //else if (cod > 5)
            //{
            //    Console.WriteLine("Codigo não existe no sitema...");

            //}
            //else {
            //    precoTot = quantidade * 1.50;
            //}


            //Console.WriteLine($"Total = R${precoTot.ToString("F2",CultureInfo.InvariantCulture)}");


            //-------------------------------------------------------------------------------------------------------

            /*  Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
              seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
               nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”*/
            //Console.WriteLine("Insira um número dentro dos intervalos");
            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //if (numero <= 25)
            //{
            //    Console.WriteLine("[0,25]");
            //}
            //else if (numero <= 50)
            //{
            //    Console.WriteLine("[25, 50]");
            //}
            //else if (numero <= 75)
            //{
            //    Console.WriteLine("[50, 75]");
            //}
            //else if (numero <= 100)
            //{
            //    Console.WriteLine("[75, 100]");
            //}
            //else if (numero < 0 || numero > 100){
            //    Console.WriteLine("Intervalo não existe");
            //}

            //Console.WriteLine("Digite o valor de x");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Digite o valor de y");
            //double y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            //if (x == 0 && y == 0) {
            //    Console.WriteLine("Origem");
            //}else if (x > 0 && y > 0){
            //    Console.WriteLine("Q1");
            //}else if (x < 0 && y > 0){
            //    Console.WriteLine("Q2");
            //}else if (x < 0 && y < 0){
            //    Console.WriteLine("Q3");
            //}else if (x > 0 && y < 0 ){
            //    Console.WriteLine("Q4");
            //}

            //ultimo exercício (Renda Imposto de renda).
            Console.WriteLine("Insira seu salário");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double ImpostoDeRenda = double.Parse(Console.ReadLine());
            double renda = 0.0;

            if (salario > 0 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");

            }
            else if (salario <= 3000.00)
            {

                renda = salario * 0.8;

            }
            else if (salario <= 4500.00)
            {
                renda = salario * 0.18;
            }
            else {
                renda = salario * 2.8;
            }

            Console.WriteLine($"Sua renda será de {renda.ToString(CultureInfo.InvariantCulture)}");




        }
    }
}
