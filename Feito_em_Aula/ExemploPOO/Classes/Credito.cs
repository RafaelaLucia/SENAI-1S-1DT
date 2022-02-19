using System;

namespace ExemploPOO.Classes
{
    public class Credito : Cartao
    {

        private float Limite = 3000f; 
        public void Pagar(){
        float valor = this.Valor;
        int vezes;

            if (valor > Limite)
            {
                Console.WriteLine("O seu limite não é suficiente para pagar esse valor!");
            } else
            {
              do
              {
                    
                Console.WriteLine($"Em quantas vezes deseja parcelar o valor {valor:C2}? (De 1 à 12x)");
                vezes = int.Parse(Console.ReadLine());

                if (vezes == 1){
                    Console.WriteLine($"Você optou por parcelar em {vezes} vez, dessa forma o juro será de 5% do valor total");
                    Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} vez de {(valor * 1.05) / vezes:C2}");

                }else if (vezes >= 2 && vezes <= 6)
                {
                    Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juro será de 5% do valor total");
                    Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} vezes de {(valor * 1.05) / vezes:C2}");
                } else if (vezes >= 7 && vezes <= 12)
                {
                    Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juro será de 8% do valor total");
                    Console.WriteLine($"Você pagará {valor * 1.08:C2} em {vezes} vezes de {(valor * 1.08) / vezes:C2}");

                } else
                {
                    Console.WriteLine("Impossível parcelar nessa quantidade, escolha um número de vezes entre 1 e 12");
                }

              } while (vezes < 1  || vezes > 12);
            }
        }
    }
}