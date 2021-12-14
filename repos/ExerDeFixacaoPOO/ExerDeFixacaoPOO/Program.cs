using System;
using System.Globalization;

namespace ExerDeFixacaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*fazer um programa para ler os valores da largura e altura de um retangulo.
             Em seguida, mostrar na tela o valor de sua áre, perímetro e diagonal. Usar uma classe como 
            mostrado no prpjeto ao lado*/

            //instanciando um retangulo

            Retangulo ret = new Retangulo();

            //primeiramente é necessário declarar as variáveis largura e altura
            Console.WriteLine("Digite a largura: ");
            ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a altura: ");
             ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados atualizados" + ret);




        }
    }
}
