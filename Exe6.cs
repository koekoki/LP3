using System;

namespace exe6
{
    class Exe6
    {
        static void Main(string[] args)
        {
            float y, x;
            Console.WriteLine("Digite as duas notas: ");
            y = float.Parse(Console.ReadLine());
            x = float.Parse(Console.ReadLine());

            if (y < 0 || y > 10 || x < 0 || x > 10)
                Console.WriteLine("Notas inválidas. ");
            else {

                float result = (x + y) / 2;
                Console.WriteLine("Média do aluno: "+result);
            }
        }
    }
}
