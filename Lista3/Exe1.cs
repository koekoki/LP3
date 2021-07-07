using System;

namespace exe1
{
    class Exe1
    {
        static void Main(string[] args)
        {
            int num = 0;

            for (int i = 1; i <= 15; i++) {

                if (i % 3 == 0) {
                    num = num + 1;
                    Console.WriteLine(num+"º numero multiplo de 3: "+i);
                }
            }
        }
    }
}
