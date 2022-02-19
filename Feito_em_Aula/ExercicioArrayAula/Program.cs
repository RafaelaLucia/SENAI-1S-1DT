using System;

namespace ExercicioArrayAula
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] paoQueijo = null;

            Console.WriteLine("Você vai ao mercado Parmeggio comprar pão de queijo: ");
            Console.WriteLine("Quantas pacotes de pães de queijo tem na prateleira? ");
            int quantidadepaes = int.Parse(Console.ReadLine());

              paoQueijo = new int [quantidadepaes];

               Console.WriteLine("Você percebe que o peso dos pacotes são diferentes, então cada pacote vem com uma certa quantidade de pãezinhos:  ");
               for (var i = 0; i < quantidadepaes; i++)
             {
               Console.WriteLine("Digita quantidade de pães de queijo no " + (i + 1) + "º pacote");
                paoQueijo[i] = int.Parse(Console.ReadLine());  
             }

             int c = 1;
             foreach (var item in paoQueijo)
             {
                 Console.WriteLine($" O {c}º pacote de pão de queijo tem {item} pães de queijo");
                 c++;
             }
        }
    }
}
