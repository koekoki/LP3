using System;

namespace exe2
{
    class Exe2
    {
        static void Main(string[] args)
        {
            int y, result;
            Console.WriteLine("Digite um numero: ");
            y = int.Parse(Console.ReadLine());

            if (y >= 0) {

                result = y * y;
                Console.WriteLine(y + " ao quadrado é: " + result);

                result = (int)Math.Sqrt(y);
                Console.WriteLine("Raiz quadrada de " + y + " é " + result);
            }
            else
                Console.WriteLine("Numero negativo não é valido. ");
        }
    }
}
