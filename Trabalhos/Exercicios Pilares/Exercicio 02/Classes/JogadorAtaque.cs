using System;

namespace Exercicio_02.Classes
{

    
    public class JogadorAtaque : JogadorFutebol
    {
        
        public override string Aposentar()
        {
        
        int calculo = 35 - this.Idade;

        if (Idade < 35)
        {
            Console.WriteLine("Para se aposentar sendo Atacante, é preciso ter 35 anos: ");
            Console.WriteLine($"Você ainda não tem idade suficiente para se aposentar, faltam {calculo} anos!");
        } else if (Idade >= 35){
            Console.WriteLine("Para se aposentar sendo Atacante, é preciso ter 35 anos: ");
            Console.WriteLine($"Você tem {Idade} anos, idade suficiente para se aposentar! :D");
        }

        return "";
        }
    }
}