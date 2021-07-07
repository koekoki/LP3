using System;

namespace exe4
{
    class Exe4
    {
        static void Main(string[] args)
        {
            int y, x, result;
            Console.WriteLine("Escreva dois numeros: ");
            y = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());

            if (x > y)
            {

                for (int i = 0; y <= x; y++)
                {

                    if (y == x)
                    {
                        Console.WriteLine(x + " é maior. \nDistância entre eles:" + i);
                    }

                    i++;

                }
            }
            else
            {

                for (int i = 0; x <= y; x++)
                {

                    if (y == x)
                    {
                        Console.WriteLine(y + " é maior. \nDistância entre eles:" +i);
                    }

                    i++;

                }

            }

        }
    }
}
