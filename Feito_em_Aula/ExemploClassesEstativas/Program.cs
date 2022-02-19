using System;
using ExemploClassesEstativas.Classes;

namespace ExemploClassesEstativas
{
    class Program
    {
        static void Main(string[] args)
        {
            // usar static para coisas mais pontuais e específicas, para fazer cálculos, validações, ou essa simples conversão:
            Console.WriteLine("Programa de conversão de moeda.");

            Console.Write("Digite o valor em reais: ");
            float valorEmReais = float.Parse(Console.ReadLine());
            
            Console.Write("Valor em U$: ");
            Console.WriteLine(Conversor.RealParaDolar(valorEmReais) + " Dólares"); //mostrar assim pq nao é possivel criar uma instância da classe, objeto, numa classe static
            
        }
    }
}
