using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization; 

namespace ExercicioProdutoPOO
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        //método de que calcula o valor total dos produtos
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
                 
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        
        }

        public void RetirarProduto(int quantidade) {
            Quantidade -=  quantidade;
                
        }

        public override string ToString()
        {
            // return $"Dados do produto: Produto: {Nome} Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)} Quantidade: {Quantidade}";

            return Nome + ",  R$"
                   + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade
                   + " Unidades , Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
                   
        
        }
    }
}

