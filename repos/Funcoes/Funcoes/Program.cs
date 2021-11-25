using System;
using System.Globalization;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número:  " );
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            

            while (x >= 0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"{raiz.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Insira outro número, por favor");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                
            }

            Console.WriteLine("Número negativo, Insira sempre um número positivo");
        }
    }
}
