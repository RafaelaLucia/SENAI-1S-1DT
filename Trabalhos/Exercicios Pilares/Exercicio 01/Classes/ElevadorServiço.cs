using System;

namespace Exercicio_01.Classes
{
    public class ElevadorServiço : Elevador
    {
        
         public override void Inicializa(){

         Console.WriteLine("\nQual a quantidade de andares no prédio?");
         andares = int.Parse(Console.ReadLine());

         Console.WriteLine("\nQual a capacidade de caixas no elevador?");
         capacidade = int.Parse(Console.ReadLine());

         Console.WriteLine($@"
Quantidade de andares: {andares}
Capacidade de caixas no elevador: {capacidade}
");
        }

        public override int Entrar(){
        Console.WriteLine("Quantas caixas deseja colocar no elevador?");
            entrar = int.Parse(Console.ReadLine());

            atualizar = totalPessoas = entrar;

            if (totalPessoas <= capacidade )
            {
               Console.WriteLine($"{entrar} caixas adicionadas, Total de caixas no elevador: {atualizar}");
            } else if (totalPessoas > capacidade)
            {
               Console.WriteLine($"O elevador só tem a capacidade de {capacidade} caixas!");
            }    
            return 0;
        }

        public override int Sair(){
            Console.WriteLine("Quantas caixas deseja retirar do elevador?");
            remover = int.Parse(Console.ReadLine());
            atualizar = totalPessoas - remover;

            if (quantidadePessoas != 0)
            {
                Console.WriteLine($"{remover} caixas foram removidas do elevador de um total de {atualizar}");

            } else if (totalPessoas == 0 && remover > 0)
            {
               Console.WriteLine("O elevador está vazio, não é possível remover nada!");
            } else if (remover > totalPessoas)
            {
               Console.WriteLine($"Não é possível remover {remover} caixas, o elevador só tem {atualizar} caixas!"); 
            }
            return 0;
        }

          public override int Subir(){
    
          Console.WriteLine($@"
Para qual andar deseja subir? de {andares} andares 
Caixas: {atualizar}
Andar atual: {AndarAtual}");
          subirEscolha = int.Parse(Console.ReadLine());

           if (subirEscolha <= andares && subirEscolha > AndarAtual ) //se andar escolhido é menor que andares no predio e maior que o andar atual, subir
         {
            Console.WriteLine($"Subindo para {subirEscolha}º andar com {atualizar} caixas!"); 
            AndarAtual = subirEscolha;
         }
     
         return 0;
        }

        public override int Descer(){ 
          Console.WriteLine($@"
Para qual andar deseja descer? de {andares} andares
Caixas: {atualizar}
Andar atual: {AndarAtual}"
);
          descerEscolha = int.Parse(Console.ReadLine());

         if (descerEscolha > 0 && descerEscolha < AndarAtual) 
         {
            Console.WriteLine($"Descendo para {descerEscolha}º andar com {atualizar} caixas!"); 
            AndarAtual = descerEscolha;
         } 
         return 0;  
    } 
    
    }

        
    
}