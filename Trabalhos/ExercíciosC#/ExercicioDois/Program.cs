using System;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {   
        Console.WriteLine("Saiba qual é a idade em anos e semanas de uma pessoa pelo ano de nascimento");    
        Console.WriteLine("Informe o ano de nascimento: ");
        int data = int.Parse(Console.ReadLine());

        int ano = DateTime.Now.Year;
        int idade = ano - data;
        double semanas = 52.14 * idade; 

        Console.WriteLine("A idade em anos é: " + idade + " anos");
        Console.WriteLine("A idade em semanas é, aproximadamente: " + semanas + " semanas");
  }
 } 
}   
