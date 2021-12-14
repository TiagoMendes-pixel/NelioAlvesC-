using System;
using System.Globalization;

namespace POOExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler o nome e salário de dois funcionários.
            //Depois mostrar o salário médio dos funcionários

            Funcionario func1, func2;

            func1 = new Funcionario();
            func2 = new Funcionario();


            //inserindo dados do primeiro funcionario.
            Console.WriteLine("Insira o nome do primeiro funcionário");
            func1.nome = Console.ReadLine();
            Console.WriteLine($"Digite o salário do {func1.nome}");
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Inserindo dados do segundo funcionario
            Console.WriteLine("Digite o nome do segundo funcionário");
            func2.nome = Console.ReadLine();
            Console.WriteLine($"Digite o salario de {func2.nome}");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //imprimindo dados do primeiro funcionario
            Console.WriteLine($"O nome do primeiro funcionario é {func1.nome} e o salário é de {func1.salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"O nome do segundo funcionario é {func2.nome} e o salário é de {func2.salario.ToString("F2", CultureInfo.InvariantCulture)}");
            


        }
    }
}
