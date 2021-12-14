using System;
using System.Globalization;

namespace Exercicio03POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Insira a primeira nota: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota: ");
            aluno.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota: ");
            aluno.nota3 = double.Parse(Console.ReadLine());


            Console.WriteLine($"a nota final é {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");


            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");

            }
        }


    }
}
