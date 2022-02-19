using System;

namespace Exercicio_02.Classes
{
    public class JogadorDefesa : JogadorFutebol
    {

    
        public override string Aposentar()
        {
        
        int calculo = 40 - this.Idade;

        if (Idade < 40)
        {
            Console.WriteLine("Para se aposentar sendo Jogador de Defesa, é preciso ter 40 anos: ");
            Console.WriteLine($"Você ainda não tem idade suficiente para se aposentar, faltam {calculo} anos!");

        } else if (Idade >= 40){
            Console.WriteLine("Para se aposentar sendo Jogador de Defesa, é preciso ter 40 anos: ");
            Console.WriteLine($"Você tem {Idade} anos, idade suficiente para se aposentar! :D");
        }
        return "";
        }
        
    }
}