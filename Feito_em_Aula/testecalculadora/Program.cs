using System;

namespace testecalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Insira o primeiro valor que você quer calcular: ");
          double n1 = double.Parse(Console.ReadLine());
          Console.WriteLine("Insira o segundo valor que você quer calcular: ");
          double n2 = double.Parse(Console.ReadLine());
          Console.WriteLine("Utilize + para somar, - para subtrarir, 'm' para multiplicar e 'd' para dividir: ");
          Console.WriteLine("Você quer somar, subtrair, multiplicar ou dividir esses valores?");
          string calculo = Console.ReadLine().ToLower();

           while (calculo == "+")
           {
               Somar(n1, n2);
               Console.WriteLine("O resultado da soma é " + Somar(n1, n2));
               
               Console.WriteLine("Você deseja calcular novamente com outra operação? (s/n)");
               string resposta = Console.ReadLine().ToLower();
               if(resposta == "s"){
               Console.WriteLine("===================================================");
               Console.WriteLine("Utilize + para somar, - para subtrarir, 'm' para multiplicar e 'd' para dividir: ");
               Console.WriteLine("Você quer somar, subtrair, multiplicar ou dividir esses valores?");
               calculo = Console.ReadLine();
               }else{
                   break;
               }
            } 

            while (calculo == "-")
           {
               Subtrair(n1, n2);
               Console.WriteLine("O resultado da subtração é " + Subtrair(n1, n2));
               
               Console.WriteLine("Você deseja calcular novamente com outra operação? (s/n)");
               string resposta = Console.ReadLine().ToLower();
               if(resposta == "s"){
               Console.WriteLine("===================================================");
               Console.WriteLine("Utilize + para somar, - para subtrarir, 'm' para multiplicar e 'd' para dividir: ");
               Console.WriteLine("Você quer somar, subtrair, multiplicar ou dividir esses valores?");
               calculo = Console.ReadLine();
               }else{
                   break;
               }
            }

            while (calculo == "m")
           {
               Multiplicar(n1, n2);
               Console.WriteLine("O resultado da multiplicação é " + Multiplicar(n1, n2));
               
               Console.WriteLine("Você deseja calcular novamente com outra operação? (s/n)");
               string resposta = Console.ReadLine().ToLower();
               if(resposta == "s"){
               Console.WriteLine("===================================================");
               Console.WriteLine("Utilize + para somar, - para subtrarir, 'm' para multiplicar e 'd' para dividir: ");
               Console.WriteLine("Você quer somar, subtrair, multiplicar ou dividir esses valores?");
               calculo = Console.ReadLine();
               }else{
                   break;
               }
            }

            while (calculo == "d")
           {
               Dividir(n1, n2);
               Console.WriteLine("O resultado da divisão é " + Dividir(n1, n2));
               
               Console.WriteLine("Você deseja calcular novamente com outra operação? (s/n)");
               string resposta = Console.ReadLine().ToLower();
               if(resposta == "s"){
               Console.WriteLine("===================================================");
               Console.WriteLine("Utilize + para somar, - para subtrarir, 'm' para multiplicar e 'd' para dividir: ");
               Console.WriteLine("Você quer somar, subtrair, multiplicar ou dividir esses valores?");
               calculo = Console.ReadLine();
               }else{
                   break;
               }
            }
          }
           

        static double Somar(double primeiroNumero, double segundoNumero) {
            return primeiroNumero + segundoNumero;
        }

        static double Subtrair(double primeiroNumero, double segundoNumero) {
            return primeiroNumero - segundoNumero;
        }

        static double Multiplicar(double primeiroNumero, double segundoNumero) {
            return primeiroNumero * segundoNumero;
        }

        static double Dividir(double primeiroNumero, double segundoNumero) {
            return primeiroNumero / segundoNumero;
        }
    }
}
        
    

