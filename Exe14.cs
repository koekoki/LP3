using System;

namespace exe14
{
    class Exe14
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.WriteLine("digite tres valores para os lados A, B e C respectivamente: ");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            if (A + B > C && B + C > A && A + C > B)
            {

                if (A == B && B == C)
                {
                    Console.WriteLine("Triângulo equilatero.");
                }
                else
                {
                    if (A != B && B != C)
                    {
                        Console.WriteLine("Triângulo escaleno. ");
                    }
                    else
                        Console.WriteLine("Triângulo isóscele");
                }
            }
            else
                Console.WriteLine("Não é um triângulo. ");
        }
    }
}
