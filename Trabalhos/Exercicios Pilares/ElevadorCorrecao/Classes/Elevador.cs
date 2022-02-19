using System;

namespace ElevadorCorrecao.Classes
{
    public abstract class Elevador
    {
        private int andarAtual;
        private int totalAndares;
        private int capacidade;
        private int pessoasPresentes;

        public void Inicializa(int capacidadeElevador, int andaresPredio){
            andarAtual = 0;
            pessoasPresentes = 0;
            capacidade = capacidadeElevador;            
            totalAndares = andaresPredio;
        }

        public void Entrar(){
           if (pessoasPresentes < capacidade)
           {
           pessoasPresentes = pessoasPresentes + 1;
           Console.WriteLine("Entrou uma pessoa no elevador");
           } else {
               Console.WriteLine("O elevador está lotado!");
           }
        }
        public void Sair(){
            if (pessoasPresentes > 0)
            {
                pessoasPresentes = pessoasPresentes - 1;
                Console.WriteLine("Saiu uma pessoa do elevador");
            } else {
                Console.WriteLine("Não tem ninguém pra remover aí, rapaz!");
            }
        }
        public void Subir(){
            Console.WriteLine("qual andar quer ir?");
            int subindo = int.Parse(Console.ReadLine());
            if (andarAtual < totalAndares)
            {
                andarAtual = andarAtual + subindo;
                Console.WriteLine($"O elevador subiu pra {andarAtual} andar");
            } else {
                Console.WriteLine("Impossivel subir mais andares!"); 
            }
        }

        public void Subir(int andarDesejado){
            if (andarDesejado > 0 && andarDesejado <= totalAndares)
            {
              andarAtual = andarDesejado; 
                Console.WriteLine($"O elevador subiu para o {andarDesejado}º andar"); 
            } else {
                Console.WriteLine("Não da pra subir mais!");
            }
        }
        public void Descer(){
             if (andarAtual > 0)
            {
                andarAtual = andarAtual - 1;
                Console.WriteLine("O elevador desceu 1 andar");
            } else {
                Console.WriteLine("Você já ta no térreo, nao da pra descer mais"); 
            }
        }
    }
}