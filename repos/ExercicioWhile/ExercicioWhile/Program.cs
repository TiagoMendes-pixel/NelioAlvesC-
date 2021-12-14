using System;

namespace ExercicioWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insira sua senha");

            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002) {
            //    Console.WriteLine("Acesso negado");
            //    senha = int.Parse(Console.ReadLine());


            //}

            //Console.WriteLine("Acesso permitido");


            //Exercicio Plano Cartesiano
            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/


            ////Declarando os vetores com x e y nas posições 0 e 1;
            //string[] valores = Console.ReadLine().Split(' ');
            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);

            //while (x != 0 && y != 0) {
            //    if (x > 0 && y > 0) {
            //        Console.WriteLine("Primeiro");
            //    } else if (x > 0 && y < 0) {
            //        Console.WriteLine("Quarto");
            //    } else if (x < 0 && y < 0) {
            //        Console.WriteLine("Terceiro");
            //    } else if (x < 0 && y > 0) {
            //        Console.WriteLine("Segundo");
            //    }

            //    valores = Console.ReadLine().Split(' ');
            //    //Console.WriteLine("Digite um valor no eixo x");
            //    x = int.Parse(valores[0]);
            //    //Console.WriteLine("Digite um valor no eixo y");
            //    y = int.Parse(valores[1]);
            //}


            //Exercicio
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.*/

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Insira o codigo correto do combustível");
            int combustível = int.Parse(Console.ReadLine());


            while (combustível > 0 && combustível != 4) {
                

                if (combustível == 1)
                    
                {
                    Console.WriteLine("Alcool");
                    alcool = alcool + 1;
                    Console.Write("Insira novamente: ");
                    combustível = int.Parse(Console.ReadLine());
                }
                else if (combustível == 2)
                {
                    gasolina = gasolina + 1;
                    Console.WriteLine("Gasolina");
                    Console.Write("Insira novamente: ");
                    combustível = int.Parse(Console.ReadLine());
                }
                else if (combustível == 3)
                {
                    Console.WriteLine("Diesel");
                    diesel = diesel + 1;
                    Console.Write("Insira novamente: ");
                    combustível = int.Parse(Console.ReadLine());

                }
                else if (combustível != 1 || combustível != 2 || combustível != 3 || combustível != 4)
                {
                    Console.Write("Insira um comando válido: ");
                    combustível = int.Parse(Console.ReadLine());

                }
              

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"alcool {alcool}");
            Console.WriteLine($"gasolina {gasolina}");
            Console.WriteLine($"diesel {diesel}");

        }
    }
}
