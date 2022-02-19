using System;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
           
     Console.WriteLine("Qual é seu sálario atual?");
     double valor = double.Parse(Console.ReadLine());

     if (valor < 500){
     double percentual = 30 / 100.0; // 30%
     double soma = valor * percentual;
     double valorFinal = soma + valor;
     Console.WriteLine("Você tem direito ao reajuste");  
     Console.WriteLine("Seu sálario agora é de: " + valorFinal);  
     }

     else{
         Console.WriteLine("Você não tem direito ao reajuste salarial"); 
     }
                    
    }
  }
}
