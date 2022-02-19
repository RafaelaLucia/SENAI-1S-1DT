using System;

namespace ExemploSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira seu nome" .ToLower());
            string nome  = Console.ReadLine() .ToLower();

            string letra = nome.Substring(0, 1);
           
            switch (letra) 
            {
                case "a":
                     Console.WriteLine("Seu nome começa com a vogal " + letra + " igual a Abelha ");
                    break;

                case "e":
                     Console.WriteLine("Seu nome começa com a vogal " + letra + " igual a Elefante");
                    break;

                case "i":
                     Console.WriteLine("Seu nome começa com a vogal " + letra + " igual a Igreja");
                    break;

                case "o":
                     Console.WriteLine("Seu nome começa com a vogal " + letra + " igual a Ovelha");
                    break;

                case "u":
                     Console.WriteLine("Seu nome começa com a vogal " + letra + " igual a Urubu");
                    break;

                default:
                      Console.WriteLine("Seu nome não começa com nenhuma vogal!");
                    break;
                    
            }
            
        }
    }
}
