using System;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Digite um número inteiro");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
                Console.WriteLine($"O numero {n1} é par amigão");
            else
                Console.WriteLine("O numero {0} é impar brother", n1); // Quando há apenas um comando, as chaves são opcionais

            Console.WriteLine("----------------------------------------------------------------------------");

            /* Encadeamento das Estruturas condicionais*/

            

            Console.WriteLine("Qual a hora atual");
            int hora = int.Parse(Console.ReadLine());


            if (hora < 12) {
                Console.WriteLine("Bom dia");

            } else if (hora <= 18) {
                Console.WriteLine("Boa tarde");
            }
            else{ 
                Console.WriteLine("Boa noite");
            }
        }
    }
}
