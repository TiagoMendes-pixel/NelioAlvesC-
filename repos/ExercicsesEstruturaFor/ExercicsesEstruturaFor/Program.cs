using System;
using System.Globalization;
namespace ExercicsesEstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicios Estrutura For

            //1- Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //X, se for o caso


            //Console.WriteLine("Insira um número"); 
            //int x = int.Parse(Console.ReadLine());




            //for (int i = 1; i <= x; i++) {
            //    if (i % 2 != 0) { 
            //        Console.WriteLine(i); 

            //    }

            //}

            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)*/

            //Console.WriteLine("Insira um número");
            //int n = int.Parse(Console.ReadLine());

            //int count_in = 0;
            //int count_out = 0;

            //for (int i = 0; i < n; i++) {
            //    int x = int.Parse(Console.ReadLine());

            //    if (x >= 10 && x <= 20)
            //    {
            //        count_in = count_in + 1;
            //    }
            //    else {
            //        count_out = count_out + 1;
            //    }


            //}

            //Console.WriteLine($"{count_in} in");
            //Console.WriteLine($"{count_out} out");



            /* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.*/


            ////Inserindo o número de casos como entrada
            //Console.WriteLine("Insira o numero de vezes");
            //int N = int.Parse(Console.ReadLine());

            //double media = 0;

            //for (int i = 1; i <= N; i++) {

            //    string[] valores = Console.ReadLine().Split(' ');
            //    double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    media = (a * 2 + b * 3 + c * 5)/10;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            //}


            //Inserindo o número do loop
            //Console.WriteLine("insira o numero do loop");
            //int n = int.Parse(Console.ReadLine());
            //int contador = 0;


            //for (int i = 1; i <= n; i++ ) {
            //    int x = int.Parse(Console.ReadLine());
            //    int y = int.Parse(Console.ReadLine());

            //    if (y != 0)
            //    {

            //        double div = (double)x / y;
            //        Console.WriteLine(div);
            //    }
            //    else {

            //        Console.WriteLine("Divisão impossível");
            //    }


            //}



            //    //Calculando o fatorial de um número
            //    Console.WriteLine("Insira um número do loop");
            //    int n = int.Parse(Console.ReadLine());

            //    int fat = 1;
            //    for (int i = 1; i <= n; i++) {

            //        fat = fat * 1;


            //    }

            //    Console.WriteLine(fat);


            //int n = int.Parse(Console.ReadLine());


            //int fat = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    fat = fat * i;
            //}

            //Console.WriteLine(fat);


            //Ler o número inteiro N e calcular todos os seus divisores

            //int n = int.Parse(Console.ReadLine());
            ////declarando o divisor
            //int divisores = 0;

            ////declarando o for
            //for (int i = 1; i <= n; i++) {
            //    //
            //    divisores = n / i;


            //    //condição -> se o resto da divisão do número pelo i for 0 então temos o divisor 
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine(i + " é divisor de " + n);
            //    }// caso contrário o numero não será um divisor
            //    else {
            //        Console.WriteLine("{0} Não é um divisor de {1}", i, n);
            //    }


            //}



            //Proximo exercicio

            //Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            //exemplo

            //Console.WriteLine("Insira o numero do  loop");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= n; i++) {
               

            //    double quad = Math.Pow(i, 2);
            //    double cubo = Math.Pow(i, 3);
            //    Console.WriteLine($"{ i} {quad } {cubo }");
            ////    Console.Write( " " + quad);
            ////    Console.WriteLine( " " + cubo);
            //}




            





        }




    }
}
