using System;

namespace exe15
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            double tempo;
            Console.WriteLine("sua idadae: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Tempo trabalhado: ");
            tempo = double.Parse(Console.ReadLine());

            if (idade >= 65)
                Console.WriteLine("idade maior que 65 anos.\nPode aposentar. ");
            else
                if (tempo >= 30)
                Console.WriteLine("Mais de 30 anos trabalhado.\nPode aposentar.");
                else
                    if (idade >= 60 && tempo >= 25)
                    Console.WriteLine("tem pelo menos 60 anos e já trabalhou 25 anos.\nPode aposentar. ");
                    else
                    Console.WriteLine("Não pode aposentar ainda.");
        }
    }
}
