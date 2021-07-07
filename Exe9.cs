using System;

namespace exe9
{
    class Exe9
    {
        /* Escreva um programa que leia um n´umero inteiro maior do que zero e devolva, na
           tela, a soma de todos os seus algarismos. Por exemplo, ao numero 251 corresponder
           ao valor 8(2+5+1). Se o numero lido n˜ao for maior do que zero, o programa terminar
           a mensagem “Numero invalido”. */
        static void Main(string[] args)
        {
            int y, resto = 0, soma = 0;
            Console.WriteLine("Escreva um número: ");
            y = int.Parse(Console.ReadLine());

            if (y > 0)
            {
                while (y > 0) {

                   resto = y % 10;
                   soma = soma + resto;
                   y = y / 10;
                }
                Console.WriteLine("Soma total dos algarismos: " + soma);
            }
            else
                Console.WriteLine("Numero inválido. ");
        }
    }
}
