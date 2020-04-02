using System;

namespace Exercicio_ClassesAtributosMetodosMembrosEstaticos.Classes
{
    class Retangulo
    {
        public double largura ;
        public double altura;

        public double Area()
        {
            return altura * largura;
        }

        public double Perimetro()
        {
            return 2 * (altura + largura);
        }

        public double Diagonal()
        {
            double diagonal = Math.Pow(altura, 2) + Math.Pow(largura, 2);
            return Math.Pow(diagonal, 2);
        }
    }
}
