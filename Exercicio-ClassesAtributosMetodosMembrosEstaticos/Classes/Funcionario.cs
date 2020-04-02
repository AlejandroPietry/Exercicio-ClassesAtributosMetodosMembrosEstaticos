using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_ClassesAtributosMetodosMembrosEstaticos.Classes
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagemDeAumento)
        {
            double aumentoTotal = salarioBruto * (porcentagemDeAumento / 100);
            salarioBruto = +aumentoTotal;
        }
    }
}
