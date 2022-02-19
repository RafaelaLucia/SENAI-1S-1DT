using System;

namespace Exercicio_02.Classes
{
    public abstract class JogadorFutebol
    {
        public string nome;
        public int anoNascimento;
        public string nacionalidade;
        public float altura;
        public float peso;
        public int Idade;

        public virtual string CalcularIdade(){

        int anoAtual = DateTime.Now.Year;
        Idade = anoAtual - anoNascimento;

        return "";
    
        }

        public virtual string Aposentar(){
        
        if (Idade < 35)
        {
            Console.WriteLine("Não é possivel");
        }
        return "";
        }

        public string Informacoes(){
        Console.WriteLine("Qual o nome do jogador?");
        nome = Console.ReadLine();

        Console.WriteLine("Em que ano o jogador nasceu?");
        anoNascimento = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual a nacionalidade do jogador?");
        nacionalidade = Console.ReadLine();

        Console.WriteLine("Qual o altura do jogador?");
        altura = float.Parse(Console.ReadLine());

        Console.WriteLine("Qual o peso do jogador?");
        peso = float.Parse(Console.ReadLine());

        return "";
        }
    }
}