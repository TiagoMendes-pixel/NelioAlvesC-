using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            //Exercicio 1 aula 46 Membros estáticos - PARTE 1
           //Criação das funções com membros dentro da própria classe.
            Console.WriteLine("Insira o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            Console.WriteLine($"Circunferencia {circ.ToString("F2", CultureInfo.InvariantCulture)}");

            double vol = Volume(raio);
            Console.WriteLine($"Volume {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi {Pi}");
        }

        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
