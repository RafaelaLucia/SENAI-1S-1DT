using System;
using Exercicio_03.Classes;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
          MaquinaDeCafe m = new MaquinaDeCafe();


          Console.WriteLine(@"
CafeteiraTabajaras Plus++
=========================

Deseja um cafézinho? (s/n) 
");
          string cafe = Console.ReadLine();

          if (cafe == "s")
          {

             Console.WriteLine(@"
Com açúcar ou sem açúcar?
digite com ou sem: 
");
             string acucar = Console.ReadLine();

             if (acucar == "com")
             {
               Console.WriteLine("Deseja inserir uma quantidade específica de açúcar? (s/n)");
               string gramas = Console.ReadLine();

               if (gramas == "s")
               {
                m.fazerCafe(0); 
               } else if (gramas == "n"){
                m.fazerCafe();
               }

             } else if (acucar == "sem")
             {
               m.fazerCafe("seu cafézinho sem açúcar está pronto, volte sempre :D");  
             }

          } else {
           Console.WriteLine("Tenha um bom dia :D");   
          }

        }
    }
}
