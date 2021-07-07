using System;

namespace exe10
{
    class Exe10
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media = 0;
            Console.WriteLine("Digite as 3 notas respectivamente: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            n1 = n1 * 0.1;
            n2 = n2 * 0.1;
            n3 = n3 * 0.2;

            media = (n1 + n2 + n3) / 0.4;

            if (media >= 60)
                Console.WriteLine("Sua média: " + media + "\nAprovado!");
            else
                Console.WriteLine("Sua média; " + media + "\nReprovado!");
        }
    }
}
