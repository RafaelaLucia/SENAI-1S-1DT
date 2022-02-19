using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            double calculoDesconto = 0;
            bool condicao = false;
            int litros;

          do 
          {
            Console.WriteLine("Informe qual combustível deseja colocar, utilize 'g' para gasolina e 'a' para álcool: ");
            string combustivel = (Console.ReadLine() .ToLower());

            switch (combustivel) 
            {
                
                case "a":
                 Console.WriteLine("Informe quantos litros você deseja colocar: ");
                 litros = int.Parse(Console.ReadLine());

                    if(litros <= 20){
                    valor = 4.90;
                    calculoDesconto = valor - 0.147;
                    Console.WriteLine("O valor a ser pago, com desconto, é igual a: " + calculoDesconto.ToString("N2"));
                    }else{
                    valor = 4.90;
                    calculoDesconto = valor - 0.245;
                    Console.WriteLine("O valor a ser pago, com desconto, é igual a: " + calculoDesconto.ToString("N2"));
                    }

                    condicao = true;
                    break;
                    
                case "g":
                 Console.WriteLine("Informe quantos litros você deseja colocar: ");
                 litros = int.Parse(Console.ReadLine());

                 if(litros <= 20){
                    valor = 5.30;
                    calculoDesconto = valor - 0.212;
                    Console.WriteLine("O valor a ser pago, com desconto, é igual a: " + calculoDesconto.ToString("N2"));
                    }else{
                    valor = 5.30;
                    calculoDesconto = valor - 0.318;
                    Console.WriteLine("O valor a ser pago, com desconto, é igual a: " + calculoDesconto.ToString("N2"));
                    }

                    condicao = true;
                    break;

                 default:
                      Console.WriteLine("Esse valor não é válido! Digite outra opção");
                  break;
            }

        } while (condicao == false);   
      }
    }
}
