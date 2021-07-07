using System;

namespace exe3
{
    class Exe3
    {
        static void Main(string[] args)
        {
            int valor, total = 0;
            Console.WriteLine("Digite 10 valores: ");
            for (int i = 0; i < 10; i++)
            {
                valor = int.Parse(Console.ReadLine());
                total = total + valor;
            }
            Console.WriteLine("Soma total: " + total);
        }
    }
}
