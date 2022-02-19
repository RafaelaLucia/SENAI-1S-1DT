using System;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual é a idade em anos? ");
            int idadeAnos = int.Parse(Console.ReadLine());

             int meses = idadeAnos * 12;
             int dias = idadeAnos * 365;
             int semanas = idadeAnos * 48;

             Console.WriteLine("Sua idade em meses é: " + meses + " meses");
             Console.WriteLine("Sua idade em dias é: " + dias  + " dias");
             Console.WriteLine("Sua idade em semanas é: " + semanas  + " semanas");

        }
    }
}
