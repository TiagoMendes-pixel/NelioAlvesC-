using System;
using System.Globalization;

namespace Exrcicio2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Insira os dados do funcionario");
            Console.WriteLine("Nome:  ");
            funcionario.Nome =  Console.ReadLine();
            Console.WriteLine("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o imposto ");
            funcionario.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(funcionario);

            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salário em qual porcetangem");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcent);

            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}
