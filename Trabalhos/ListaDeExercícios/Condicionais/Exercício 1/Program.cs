using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe seu ano de nascimento: ");
            int anoUsuario = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int direitoVoto = anoAtual - anoUsuario;

            if (direitoVoto >= 16 && direitoVoto < 18){
                Console.WriteLine("Você pode votar!");
            
            }else if (direitoVoto >= 18){

                Console.WriteLine("você tem obrigação de votar!");

            }else{

                Console.WriteLine("você não pode votar!");
            }
        }
    }
}
