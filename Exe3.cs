using System;

namespace exe3
{
    class Exe3   
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Digite um numero: ");
            y = int.Parse(Console.ReadLine());

            if (y % 2 == 0)
            {
                Console.WriteLine("Par. ");
            }
            else
                Console.WriteLine("Ímpar. ");
        }
    }
}
