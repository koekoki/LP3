using System;

namespace exe5
{
    class Exe5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (i % 11 == 0 && i != 11)
                {
                    Console.WriteLine("Multipo de 11: " + i);
                    break;
                }
            }
            for (int i = 1; i < num; i++)
            {
                if (i % 13 == 0 && i!= 13)
                {
                    Console.WriteLine("Multiplo de 13: " + i);
                    break;
                }
            }
            for (int i = 1; i < num; i++)
            {
                if (i % 17 == 0 && i != 17)
                {
                    Console.WriteLine("Multiplo de 17: " + i);
                    break;
                }
            }

        }
    }
}