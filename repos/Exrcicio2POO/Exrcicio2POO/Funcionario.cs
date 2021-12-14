using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exrcicio2POO
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;


        public double SalarioLiquido() {
            return SalarioBruto - imposto;
        }


        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        
        }

        

        public override string ToString()
        {
            return $"O nome é {Nome} " +
                $"O salario bruto é R${SalarioBruto.ToString("F2", CultureInfo.InvariantCulture )} " +
                $"O imposto é R${imposto.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"O salário líquido é R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
                

        }

    }
}
