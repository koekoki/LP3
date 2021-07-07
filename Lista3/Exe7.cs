using System;

namespace exe7
{
    class Exe7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número par:");
            int num = int.Parse(Console.ReadLine());

            if (num < 0 || num % 2 != 0) {

                Console.WriteLine("Numero inválido. \n");
                
            
            }else
            for (int i = 0; i <= num; i++) {

                if (i % 2 == 0)
                    Console.Write(" "+i);

            }
        }
    }
}
