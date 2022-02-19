using System;
using ElevadorCorrecao.Classes;

namespace ElevadorCorrecao
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Console.WriteLine("Exercicio Elevador");

            ElevadorSocial s = new ElevadorSocial();

            s.Inicializa(4, 5);

            do
            {

            Console.WriteLine("Qual a opção que deseja executar?\n1 - Entrar\n2 - Sair\n 3 - Subir\n 4 - Descer\n 99 - encerrar programa");
            resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                s.Entrar();
                    break;

                case "2":
                s.Sair();
                    break;

                case "3":
                Console.WriteLine("Deseja escolher o andar de destinoo? (S/n)");
                string respostaSubir = Console.ReadLine().ToLower();
                if (respostaSubir == "s")
                {
                Console.WriteLine("Qual andar? pra subir");
                int numeroSubir = int.Parse(Console.ReadLine());
                s.Subir(numeroSubir);
                }else {
                s.Subir();
                }
                    break;

                case "4":
                s.Descer();
                    break;

                case "99":
                Console.WriteLine("Obg por usar noosso elevador ^^ ");
                    break;

                default:
                Console.WriteLine("Opção Inválida!!!");
                    break;
            }
            
            
            } while (resposta != "99");


        }
    }
}
