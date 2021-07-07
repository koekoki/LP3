using System;
using System.Collections;
namespace exe6
{
    class Exe6
    {
        static void Main(string[] args)
        {
            ArrayList num = new ArrayList();
            int x, maior= 0, menor = 0, posicao_menor = 0, posicao_maior =0;

            Console.WriteLine("Digite os numeros: ");
            for (int i = 1; i >=0 ; i++) {
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    break;
                }
                else
                    num.Add(x);      
            }

            for (int i = 0; i < num.Count; i++) {

                if ((int)num[i] < menor)
                {
                    menor = (int)num[i];
                    posicao_menor = i;
                }
                else if ((int)num[i] > maior)
                {
                    maior = (int)num[i];
                    posicao_maior = i;
                }

            }
            Console.WriteLine("Menor número: " + num[posicao_menor]);
            Console.WriteLine("Maior número: " + num[posicao_maior]);
        }
    }
}
