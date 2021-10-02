using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    class Retangulo : Forma
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            base.setCor("Amarelo");
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do Rentâgulo: " + this.calcularArea());
        }

        public Retangulo(double altura, double largura, string cor)
        {
            base.setCor(cor);
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do Retangulo: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return altura * largura;
        }

        public override void digaOi(string msg)
        {
            Console.WriteLine("Oi: " + msg);
        }
    }
}
