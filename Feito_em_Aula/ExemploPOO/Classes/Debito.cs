using System;

namespace ExemploPOO.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 600f; // so vai ter saldo suficiente se for maior que 2k, nesse exemplo vai dar saldo insuficiente

        public void Pagar(){
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente para pagar este valor!");
            } else
            {
                Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso!");
            }
        }
    }
}