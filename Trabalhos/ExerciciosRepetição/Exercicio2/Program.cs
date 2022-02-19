using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool senhaValor = false;

            Console.WriteLine("Insira seu nome de usuário: ");
            string nome = Console.ReadLine();

            while (senhaValor == false)
           {
            Console.WriteLine("Insira sua senha: ");
            string senha = Console.ReadLine();
               if(nome != senha){
                Console.WriteLine("Senha válida");
                senhaValor = true;
               }else{
                Console.WriteLine("Senha inválida, a senha não pode ser igual ao nome do usuário");
               }
           }
        }
    }
}
