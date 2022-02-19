using System;

namespace Backend1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Qual é o seu nome?");
           string nomePessoa = Console.ReadLine();

           Console.WriteLine("Buonasera! Boun pomeriggio " + nomePessoa + "!!!");

            // var estadoDoSemaforo = Qual é o estado do semáforo?
            // int exemplo = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Qual é o primeiro número?");
               int primeiroNumero = int.Parse(Console.ReadLine());

               Console.WriteLine("Ótimo, digite o segundo número: ");
               int segundoNumero = int.Parse(Console.ReadLine());

               Console.WriteLine("Por fim, digite o terceiro número: ");
               int terceiroNumero = int.Parse(Console.ReadLine());

               Console.WriteLine("O primeiro número digitado foi: " + primeiroNumero);
               Console.WriteLine("O segundo número digitado foi: " + segundoNumero);
               Console.WriteLine("O terceiro número digitado foi: " + terceiroNumero);

               int soma = primeiroNumero + segundoNumero + terceiroNumero;
               int sub = primeiroNumero - segundoNumero - terceiroNumero;
               int media = soma / 3;
               
               Console.WriteLine("A soma desses números foi: " + soma);
               Console.WriteLine("A subtração desses números na ordem colocada foi: " + sub);
               Console.WriteLine("A média desses números foi: " + media);


               

                


    
        }
    }
}
