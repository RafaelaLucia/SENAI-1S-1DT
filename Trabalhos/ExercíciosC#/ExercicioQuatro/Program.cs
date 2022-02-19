using System;

namespace ExercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a idade do nadador(a)? ");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 1 && idade <=4){
            Console.WriteLine("nadador(a) está na categoria Baby");
            }

            if(idade >= 5 && idade <=7){
            Console.WriteLine("nadador(a) está na categoria Infantil A");
            }

            if(idade >= 8 && idade <=10){
            Console.WriteLine("nadador(a) está na categoria Infantil B");    
            }

             if(idade >= 11 && idade <=13){
            Console.WriteLine("nadador(a) está na categoria Juvenil A");    
             }

             if(idade >= 14 && idade <=17){
            Console.WriteLine("nadador(a) está na categoria Juvenil B");
             }

             if(idade >= 18){
            Console.WriteLine("nadador(a) está na categoria Sênior");
            }
        }
     }
  }

