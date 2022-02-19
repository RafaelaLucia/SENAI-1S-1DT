using System;

namespace Exercicio_02.Classes
{
    public class JogadorMeio : JogadorFutebol
    {
        public override string Aposentar()
        {
        
        int calculo = 38 - this.Idade;

        if (Idade < 38)
        {
            Console.WriteLine("Para se aposentar sendo Jogador de Meio-Campo, é preciso ter 38 anos: ");
            Console.WriteLine($"Você ainda não tem idade suficiente para se aposentar, faltam {calculo} anos!");
        } else if (Idade >= 38){
            Console.WriteLine("Para se aposentar sendo Jogador de Meio-Campo, é preciso ter 38 anos: ");
            Console.WriteLine($"Você tem {Idade} anos, idade suficiente para se aposentar! :D");
            
        }
        return "";
        }
        
    }
}