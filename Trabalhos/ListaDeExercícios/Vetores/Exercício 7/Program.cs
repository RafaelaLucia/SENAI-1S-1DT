using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[3];

            Console.WriteLine($"Insira {valores.Length} numeros");

            for (var i = 0; i < valores.Length; i++)
            {
            Console.WriteLine("Insira o " + (i + 1) + " º número");
            valores[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("====================");
            for (var i = (valores.Length - 1); i >= 0; i--)
            {
                Console.WriteLine("\n" + valores[i]);
            }
             Console.WriteLine("====================");
            
        }
    }
}
