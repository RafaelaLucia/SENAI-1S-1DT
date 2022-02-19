using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Você deseja receber um 'Buon Pomeriggio'? (s/n)");
          string resposta = Console.ReadLine().ToLower();

           while (resposta == "s")
           {
               Console.WriteLine("Buon Pomerriggio :D");

               Console.WriteLine("Você deseja receber mais um'Buon Pomeriggio'?");
               resposta = Console.ReadLine();
               // ou resposta = "nao" para forçar o encerramento do programa, o que estiver em aspas pode ser qualquer palavra diferente de sim
           }

           //obs: provavelmente o programa não vai funcionar com duas coisas diferentes, mas eu não vou criar uma nova pasta para o próximo exemplo, nem comentar o exemplo anterior
        
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
              }else {
                  Console.WriteLine("Bem, parece que você não é um verdadeiro fã de Paulo Brandão");
              }
            }
            // obs: ta funcionando os dois esquece o que eu falei
    
        }

    }
}
