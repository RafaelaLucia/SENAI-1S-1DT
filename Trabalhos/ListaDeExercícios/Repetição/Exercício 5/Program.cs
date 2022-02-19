using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int tabuada = 1; tabuada <= 10; tabuada ++)
            {
                Console.WriteLine("====== Tabuada do " + tabuada + " =======");
                for (int numero = 1; numero <= 10; numero ++)
                {
                    Console.WriteLine($"{tabuada}x{numero} = {tabuada * numero}");
                }
                Console.WriteLine("===========================");
                Console.WriteLine();

            }
          
        }
    }
}
