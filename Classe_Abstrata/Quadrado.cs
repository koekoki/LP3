using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            base.setCor("azul");
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea());
        }

        public Quadrado(double lado, string cor)
        {
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return lado * lado;
        }

        public override void digaOi(string msg)
        {
            Console.WriteLine("Oi: " + msg);
        }
    }
}
