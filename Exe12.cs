using System;

namespace exe12
{
    class Exe12
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um numeor de 1 a 7");
            n = int.Parse(Console.ReadLine());

            switch(n){
                case 1:
                    Console.WriteLine("SEGUNDA.");
                    break;

                case 2:
                    Console.WriteLine("TERÇA.");
                    break;

                case 3:
                    Console.WriteLine("QUARTA.");
                    break;

                case 4:
                    Console.WriteLine("QUINTA.");
                    break;

                case 5:
                    Console.WriteLine("SEXTA.");
                    break;

                case 6:
                    Console.WriteLine("SÁBADO.");
                    break;

                case 7:
                    Console.WriteLine("DOMINGO.");
                    break;

            }
        }
    }
}
