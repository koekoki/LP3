using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Abstrata
{
    abstract class Forma
    {
        private string cor;
        private double area;

        protected void setCor(string cor) {

            this.cor = cor;
            Console.WriteLine("\nCor da forma: " + this.cor);

        }

        public abstract double calcularArea();
        public abstract void digaOi(string msg);
    }
}
