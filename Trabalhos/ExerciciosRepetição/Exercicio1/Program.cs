using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
             bool notaCorreta = false;

            Console.WriteLine("Insira uma nota de 0 a 10: ");
            int nota = int.Parse(Console.ReadLine());

            while (notaCorreta == false)
            {
              if(nota <10 && nota >0){
                  Console.WriteLine("Esta nota é válida, a nota inserida foi: " + nota);
                  notaCorreta = true;
              }else {
                  Console.WriteLine("Esta nota não é válida, insira uma nota entre 0 a 10: ");
                  nota = int.Parse(Console.ReadLine());
              }
            }
                
            }
        }
    }

