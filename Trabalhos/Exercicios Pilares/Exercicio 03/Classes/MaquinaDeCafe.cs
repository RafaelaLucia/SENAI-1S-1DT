using System;

namespace Exercicio_03.Classes
{
    public class MaquinaDeCafe
    {
        public int acucarDisponivel = 500;

        public void fazerCafe(int gramas) {

        Console.WriteLine("informe a quantidade em gramas que deseja de açúcar: ");
        int quantidade = int.Parse(Console.ReadLine());
        
        if (acucarDisponivel < quantidade)
        {
          Console.WriteLine("A máquina não possui açúcar suficiente para esta quantidade, deseja um cafézinho sem açúcar? (s/n) ");
          string escolha = Console.ReadLine();
          if (escolha == "s")
          {
            Console.WriteLine("Saindo cafézinho sem açúcar...");
            Console.WriteLine("seu cafézinho sem açúcar está pronto, volte sempre :D");
          } else if (escolha == "n")
          {
            Console.WriteLine("Obrigado por utilizar nosso sistema ;)");
          }
        } else if (acucarDisponivel > quantidade && quantidade > 0)
        {
            Console.WriteLine("Saindo cafézinho com açúcar..."); 
            Console.WriteLine($"seu cafézinho com {quantidade} gramas de açúcar está pronto, volte sempre :D"); 
            
        }

        }
        public void fazerCafe(){
        if (acucarDisponivel >= 10)
        {
          Console.WriteLine("Saindo cafézinho com açúcar...");  
          Console.WriteLine("seu cafézinho com açúcar está pronto, volte sempre :D");  
          
        } else {
          Console.WriteLine("A máquina não possui açúcar suficiente, deseja um cafézinho sem açúcar?");
          string escolha = Console.ReadLine();
          if (escolha == "s")
          {
            Console.WriteLine("Saindo cafézinho sem açúcar...");
            Console.WriteLine("seu cafézinho sem açúcar está pronto, volte sempre :D");  

          } else if (escolha == "n")
          {
            Console.WriteLine("Obrigado por utilizar nosso sistema ;)");
          }
        }

        }
        public void fazerCafe(string sem) {
        Console.WriteLine("Saindo cafézinho sem açúcar...");
         Console.WriteLine("seu cafézinho sem açúcar está pronto, volte sempre :D");  
        }



    }
}