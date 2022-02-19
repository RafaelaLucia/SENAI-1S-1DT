using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome do produto que você deseja calcular: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a quantidade que você possui deste produto?: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço de uma unidade desse produto? ");
            double unidade = double.Parse(Console.ReadLine());

            double total = quantidade * unidade;

            if(quantidade <= 5){
            double desconto = total - 0.98;
            Console.WriteLine("O total a pagar é: R$" + total + " reais");
            Console.WriteLine("O total a pagar, com desconto adicionado, é: R$" + desconto + " reais");
            } else if(quantidade > 5 && quantidade <= 10){
            double desconto = total - 0.97;
            Console.WriteLine("O total a pagar é: R$" + total + " reais");
            Console.WriteLine("O total a pagar, com desconto adicionado, é: R$" + desconto + " reais");   
            } else {
            double desconto = total - 0.95;
            Console.WriteLine("O total a pagar é: " + total + " reais R$");
            Console.WriteLine("O total a pagar, com desconto adicionado, é: R$" + desconto + " reais");   
            }
        }
    }
}
