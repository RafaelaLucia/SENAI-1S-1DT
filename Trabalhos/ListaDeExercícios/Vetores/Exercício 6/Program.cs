using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {

          string[] nomes = null; 
          string outro = "";

          nomes = new string [3];

          for (int i = 0; i < 3; i++)
          {
              Console.WriteLine("Escreva o " + (i + 1) + " º nome");
              nomes[i] = (Console.ReadLine());  
          }

             Console.WriteLine("Escreva mais um nome para busca: ");
             outro = (Console.ReadLine()); 
          
            foreach (var item in nomes)
            {
              if(item == outro){
                Console.WriteLine("ACHEI um nome igual :)");
                break;
              } else if (item != outro){
                Console.WriteLine("NÃO ACHEI um nome igual :(" + "");
                break;
              }
            }
            
        }
        
    }
}
