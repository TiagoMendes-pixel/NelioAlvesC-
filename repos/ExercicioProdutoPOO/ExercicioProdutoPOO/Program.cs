using System;
using System.Globalization;
namespace ExercicioProdutoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            //Entrando com os dados do produto.
            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados atualizados: " + produto); 

           
            Console.WriteLine("Digite a quantidade de  produtos que serão adicionados");
            int qteAdd = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(qteAdd);

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos que serão retirados");
            int qteExt = int.Parse(Console.ReadLine());
            produto.RetirarProduto(qteExt);

            Console.WriteLine("Dados atualizados: " + produto);

        }
    }
}
