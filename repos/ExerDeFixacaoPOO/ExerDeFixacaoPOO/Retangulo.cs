using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerDeFixacaoPOO
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public double ValorDaArea()
        {
            return largura * altura;
        }

        public double Perimetro() {
            return (largura * 2) + (altura * 2);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
        //public double Diagonal() { 
        //return Math.Pow(largura, 2) + Math.Pow(altura, 2)
        //}

        public override string ToString()
        {
            return $" A largura é de {largura} e a altura é de {altura}.  " 
                + $" O valor da área é de  {ValorDaArea().ToString("F2", CultureInfo.InvariantCulture)}"
                + $" E o perímetro é de {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}"
                + $"E o valor da diagonal é de {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";


        }
    }

    



   
}
