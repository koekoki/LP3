using System;

namespace exe7
{
    class Exe7
    {
        static void Main(string[] args)
        {
            double e, s;
            Console.WriteLine("Digite o valor do salário: ");
            s = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da emprestação: ");
            e = double.Parse(Console.ReadLine());

            s = s * 0.2;

            if (s >= e)
                Console.WriteLine("Empréstimo concedido! ");
            else
                Console.WriteLine("Empréstimo não concedido. ");
        }
    }
}
