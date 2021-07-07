using System;

namespace exe11
{
    class Exe11
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media = 0;
            Console.WriteLine("Digite a nota de laboratório (peso 2): ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da avaliação semestral (peso 3): ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do exame final (peso 5): ");
            n3 = double.Parse(Console.ReadLine());

            n1 = n1 * 0.2;
            n2 = n2 * 0.3;
            n3 = n3 * 0.5;

            media = (n1 + n2 + n3);

            if (5 <= media && media <= 10)
            {
                Console.WriteLine("Sua média: " + media + "\nAprovado!");
            }
            else
            {
                if (media >= 3 && media <= 4.9)
                {
                    Console.WriteLine("Sua média; " + media + "\nRecuperção!");
                }
                else
                {
                    if (media >= 0 && media <= 2.9)
                    {
                        Console.WriteLine("Sua média: " + media + "\nReprovado!");
                    }
                }
            }
        }
    }
}
