using System;

namespace Classe_Abstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q1 = new Quadrado(3);
            Circulo c1 = new Circulo(2);
            Retangulo r1 = new Retangulo(4, 5);
            Triangulo t1 = new Triangulo(2, 5);
        }   
    }
}
