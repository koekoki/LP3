using System;

namespace exe2
{
    class Exe2
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Utilizando 'for': \n");
            for (i = 0; i <= 100; i++) {

                Console.Write(" "+i);

            }
            i = 0;

            Console.WriteLine("\n\nUtilizando 'While': \n");
            while (i <=100) {

                Console.Write(" " + i);
                i = i+1;

            }

            i = 0;

            Console.WriteLine("\n\nUtilizando 'Do While': \n");

            do {

                Console.Write(" " + i);
                i = i+1;

            }
            while (i<=100);
        }
    }
}
