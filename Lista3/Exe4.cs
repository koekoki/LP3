using System;

namespace exe4
{
    class Exe4
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escreva um número: ");
                num = int.Parse(Console.ReadLine());
                
            for (int i = 0; num > 0; i++) {

                if (i % 2 != 0) {

                    Console.WriteLine(i);
                    num = num - 1;

                }
            
            }
        }
    }
}
