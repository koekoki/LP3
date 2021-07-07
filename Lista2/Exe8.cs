using System;

namespace exe8
{
    class Exe8
    {
        static void Main(string[] args)
        {
            double altura;
            String sexo;
            Console.WriteLine("Entre com o altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o sexo: ");
            sexo = Console.ReadLine();

            if (sexo == "Femenino" || sexo == "feminino")
            {
                double ideal = (72.7 * altura) - 58;
                Console.WriteLine("Peso ideal para mulher: " + ideal);
            }
            else
                if (sexo == "Masculino" || sexo == "masculino") {
                double ideal = (62.1 * altura) - 44.7;
                Console.WriteLine("Peso ideal para homem: " + ideal);
            }
        }
    }
}
