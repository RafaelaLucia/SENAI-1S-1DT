using System;

namespace Exercicio_01.Classes
{
    public class Elevador
    {
        public int AndarAtual;
        public int andares;
        public int capacidade;
        public int totalPessoas;
        public int subirEscolha;
        public int descerEscolha;
        public int remover;
        public int entrar;
        public int quantidadePessoas;
        public int atualizar;

        public virtual void Inicializa(){

         Console.WriteLine("\nQual a quantidade de andares no prédio?");
         andares = int.Parse(Console.ReadLine());

         Console.WriteLine("\nQual a capacidade de pessoas no elevador?");
         capacidade = int.Parse(Console.ReadLine());

         Console.WriteLine($@"
Quantidade de andares: {andares}
Capacidade de pessoas no elevador: {capacidade}
");
        }

        public virtual int Entrar(){
            Console.WriteLine("Quantas pessoas desejam entrar no elevador?");
            entrar = int.Parse(Console.ReadLine());

            atualizar = totalPessoas = entrar;

            if (totalPessoas <= capacidade )
            {
               Console.WriteLine($"{entrar} pessoas entraram, Total de pessoas no elevador: {atualizar}");
            } else if (totalPessoas > capacidade)
            {
               Console.WriteLine($"O elevador só tem a capacidade de {capacidade} pessoas!");
            }
                  
         return 0;

        }      
        public virtual int Sair(){
            Console.WriteLine("Quantas pessoas desejam sair do elevador?");
            remover = int.Parse(Console.ReadLine());
            atualizar = totalPessoas - remover;

            if (quantidadePessoas != 0)
            {
                Console.WriteLine($"{remover} pessoas sairam do elevador de um total de {atualizar}");

            } else if (totalPessoas == 0 && remover > 0)
            {
               Console.WriteLine("O elevador está vazio, não é possível remover ninguém!");
            } else if (remover > totalPessoas)
            {
               Console.WriteLine($"Não é possível remover {remover} pessoas, o elevador só tem {atualizar} pessoas!"); 
            }
            return 0;
        }

          public virtual int Subir(){
    
          Console.WriteLine($@"
Para qual andar deseja subir? de {andares} andares 
Pessoas: {atualizar}
Andar atual: {AndarAtual}");
          subirEscolha = int.Parse(Console.ReadLine());

           if (subirEscolha <= andares && subirEscolha > AndarAtual && atualizar > 0 ) //se andar escolhido é menor que andares no predio e maior que o andar atual, subir
         {
            Console.WriteLine($"Subindo para {subirEscolha}º andar com {atualizar} pessoas!"); 
            AndarAtual = subirEscolha;

         } else if (atualizar == 0)
         {
            Console.WriteLine($"Não é possível subir com o elevador vazio!"); 

         } else if (subirEscolha > andares)
         {
            Console.WriteLine($"Não é possível subir mais que {andares} andares!"); 

         } else if (subirEscolha == AndarAtual)
         {
            Console.WriteLine($"Você já está no {AndarAtual} andar!"); 

         } 
         
         if (subirEscolha < AndarAtual) //andar atual é igual ao numero de andares, e escolha é menor que andar atual
         {
            Console.WriteLine($"Não é possível subir para baixo!"); 

         }
           
         return 0;
        }

        public virtual int Descer(){
            
          Console.WriteLine($@"
Para qual andar deseja descer? de {andares} andares
Pessoas: {atualizar}
Andar atual: {AndarAtual}"
);
          descerEscolha = int.Parse(Console.ReadLine());

         if (descerEscolha > 0 && descerEscolha < AndarAtual) 
         {
            Console.WriteLine($"Descendo para {descerEscolha}º andar com {atualizar} pessoas!"); 
            AndarAtual = descerEscolha;
         } else if (descerEscolha > AndarAtual) 
         {
            Console.WriteLine($"Não é possível descer para cima!"); 

         } else if (descerEscolha < 0)
         {
           Console.WriteLine($"Não é possível descer além do térreo!"); 

        } else if (descerEscolha == AndarAtual)
          {
          Console.WriteLine($"Você já está no {AndarAtual} andar!");  
          }
         return 0;  
    } 
    } 
}

    
