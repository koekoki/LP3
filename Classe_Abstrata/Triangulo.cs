using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    class Triangulo : Forma
    {
        private double b;
        private double altura;

        public Triangulo(double b, double altura)
        {
            base.setCor("Vermelho");
            this.altura = altura;
            this.b = b;
            Console.WriteLine("Area do Triangulo: " + this.calcularArea());
        }

        public Triangulo(double b, double altura, string cor)
        {
            base.setCor(cor);
            this.b = b;
            this.altura = altura;
            Console.WriteLine("Area do Triangulo: " + this.calcularArea() );
        }

        public override double calcularArea()
        {
            return (altura * b) / 2;
        }

        public override void digaOi(string msg)
        {
            Console.WriteLine("Oi: " + msg);
        }
    }
}