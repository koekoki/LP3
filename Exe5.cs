using System;

namespace exe5
{
    class Exe5
    {
        static void Main(string[] args)
        {
            int y, x;
            Console.WriteLine("Digite dois numeros: ");
            y = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            if (y == x)
            {
                Console.WriteLine("Os valores são iguais.");
            }
            else
            if (y > x)
            {
                Console.WriteLine(y + " é maior que " + x);
            }
            else
                Console.WriteLine(x + " é maior que " + y);
        }
    }
}
