using System;

namespace DesafioArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = null;
            double[] valor = null;
            double[] quantidade = null;

            Console.WriteLine("Insira a quantidade de produtos que você deseja cadastrar: ");
            int produtos = int.Parse(Console.ReadLine());

              nome = new string [produtos];

               for (var i = 0; i < produtos; i++)
             {
                Console.WriteLine("Escreva o nome do " + (i + 1) + "º produto");
                nome[i] = (Console.ReadLine()); 
             }

              quantidade = new double [produtos];

              for (var i = 0; i < produtos; i++)
             {
                Console.WriteLine("Digita a quantidade que você possui do " + (i + 1) + "º produto");
                quantidade[i] = double.Parse(Console.ReadLine()); 
             }

              valor = new double [produtos];

              for (var i = 0; i < produtos; i++)
             {
                Console.WriteLine("Digita o valor de uma unidade do " + (i + 1) + "º produto");
                valor[i] = double.Parse(Console.ReadLine()); 
             }
             
             Console.WriteLine("=================================");
             Console.WriteLine("Nome        Quantidade      Valor");
             for (var i = 0; i < produtos; i++)
             {
            Console.WriteLine($@"{nome[i]}        {quantidade[i]}        {valor[i]}");
             }
             Console.WriteLine("_________________________________");


        }
    }
}
