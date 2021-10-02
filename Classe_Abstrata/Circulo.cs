using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            base.setCor("rosa");
            this.raio = raio;
            Console.WriteLine("Area do Circulo: " + this.calcularArea());
        }

        public Circulo(double raio, string cor)
        {
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("Area do Circulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return (2 * 3.14 * raio);
        }

        public override void digaOi(string msg)
        {
            Console.WriteLine("Oi: " + msg);
        }
    }
}
