using System;

namespace ExemploPOO.Classes
{
    public class Boleto : Pagamento // dois pontos e nome da classe para herdar
    {
        private string codigoDeBarras;

        Random r = new Random();

        public void Registrar(){
            codigoDeBarras = r.Next(3000000).ToString();

            Console.WriteLine($"Boleto gerado com o código {codigoDeBarras}");
            Console.WriteLine($"Boleto registrado com desconto, o valor agora é de: {this.Valor *  0.88:C2}"); //this para ele entender de onde vem o termo valor, que no caso vem do pagamento
        } // o C2 é para aparecer o R e $ para dinheiro, com as devidas virgulas, vai converter para uma apresentacao monetária                      
    }
}