using System;

namespace ExemploPOO.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;

        public string CVV;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira do cartão: ");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite o número do cartão: ");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o titular do cartão: ");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o CVV do cartão: ");
            CVV = Console.ReadLine();

            return $"cartão de número {Numero} salvo com sucesso";
        }

    }
}