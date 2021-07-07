using System;

namespace exe13
{
    class Exe13
    {
        /* A = ((basemenor +basemenor) ∗altura)/2. */
        static void Main(string[] args)
        {
            double B, b, h, A;
            Console.WriteLine("digite a base maior do trapézio: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a base menor do trapézio: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a base altura do trapézio: ");
            h = double.Parse(Console.ReadLine());

            if (B > 0 && b > 0)
            {
                A = ((B + b) * h) / 2;
                Console.WriteLine("Área do trápézio: " + A);
            }
            else
                Console.WriteLine("Valores inválidos. ");
        }
    }
}
