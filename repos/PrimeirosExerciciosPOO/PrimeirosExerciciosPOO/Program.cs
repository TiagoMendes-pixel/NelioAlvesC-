using System;

namespace PrimeirosExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeiros passos com a orientação objetos

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();




            //inserindo a primeira pessoa
            Console.WriteLine("Digite o nome da primeira pessoa");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa");
            pessoa1.idade = int.Parse(Console.ReadLine());

            //inserindo a segunda pessoa
            Console.WriteLine("Digite o nome da segunda pessoa");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Digie a idade da segunda pessoa");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"{pessoa1.nome} é mais velho");

            }
            else {
                Console.WriteLine($"{pessoa2.nome} é mais velho");
            
            }



            


        
        
        }   

    }
}
