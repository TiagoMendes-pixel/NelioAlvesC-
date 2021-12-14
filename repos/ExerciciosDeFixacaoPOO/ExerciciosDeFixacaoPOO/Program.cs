using System;
using System.Globalization;

namespace ExerciciosDeFixacaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha

            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Digite os dados da primeira pessoa");
            //Console.WriteLine("Nome:  ");
            //p1.Nome = Console.ReadLine();
            //Console.WriteLine("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite os dados da segunda pessoa");
            //Console.WriteLine("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.WriteLine("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine($"Pessoa mais velha é {p1.Nome}");
            //}
            //else {
            //    Console.WriteLine($"Pessoa mais velha é {p2.Nome}");
            //}


            //Fazer um programa para ler nome e salário de dois funcionarios. Depos, mostrar o salário médio dos funcionários

            Pessoa func1 = new Pessoa();
            Pessoa func2 = new Pessoa();

            Console.WriteLine("Insira os dados do funcionario 1");
            Console.WriteLine("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Insira os dados do funcionario 2");
            Console.WriteLine("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (func1.salario + func2.salario) / 2;

            Console.WriteLine("A média dos salários dos dois funcionários é de " + Media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
