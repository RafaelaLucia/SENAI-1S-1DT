using System;
using Exercicio_02.Classes;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorDefesa d = new JogadorDefesa();
            JogadorAtaque a = new JogadorAtaque();
            JogadorMeio m = new JogadorMeio();


            Console.WriteLine($@"
Escolha a posição do Jogador que quer calcular:
1 - Defesa
2 - Ataque
3 - Meio-Campo           
        ");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
            d.Informacoes();
            d.CalcularIdade();
            d.Aposentar();
                break;

            case 2:
            a.Informacoes();
            a.CalcularIdade();
            a.Aposentar();
                break;

            case 3:
            m.Informacoes();
            m.CalcularIdade();
            m.Aposentar();
                break;

            default:
            break;
        }
        
        }
    
    }
}
