using System;
using Exercicio_ClassesAtributosMetodosMembrosEstaticos.Classes;


namespace Exercicio_ClassesAtributosMetodosMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXECICIO 1*/
            Retangulo retangulo = new Retangulo();

            retangulo.altura = 4;
            retangulo.largura = 3;

            Console.WriteLine("Area: " + retangulo.Area());
            Console.WriteLine("Perimetro: "+ retangulo.Perimetro());
            Console.WriteLine("Diagonal: "+ retangulo.Diagonal());

            /* EXECICIO 2*/
            Funcionario funcionario = new Funcionario();

            funcionario.nome = "João Silva";
            funcionario.salarioBruto = 7000;
            funcionario.imposto = 650;

            Console.WriteLine($"Funcionario: {funcionario.nome}, ${funcionario.SalarioLiquido()}");
            funcionario.AumentarSalario(10);
            Console.WriteLine($"Dados atualizados: {funcionario.nome}, ${funcionario.SalarioLiquido()}");
            
        }
    }
}
