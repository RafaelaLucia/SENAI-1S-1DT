using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answerCorreta = false;

            Console.WriteLine("Qual a idade de Paulo Brandão?");
            string answer = Console.ReadLine();
            // eu coloquei answer ao inves de resposta porque vai da conflito com a classe do exemplo acima

            while (answerCorreta == false)
            //enquanto a answerCorreta for false, ele continuara a perguntar a idade
            {
              Console.WriteLine("Não!! Qual a idade de PAULO BRANDÃO!? >:(");
              answer = Console.ReadLine();

              if(answer == "32"){
                  Console.WriteLine("Parabéns! Você é do balacubaco :D");
                  answerCorreta = true;
              }
            
                
            
                
            
            }
         
        }
    }
}

