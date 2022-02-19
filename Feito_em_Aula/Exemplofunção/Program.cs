using System;

namespace Exemplofunção
{
    class Program
    {
        static void Main(string[] args) // o tipo do método é void, void significa "vazio" e significa que não retorna nenhum valor. funções que retornam um valor pode ser colocadas dentro duma variável, igual o string nome = writeline 
        {   
             //tem que chamar a função dentro da main senão ela não vai ser executada
            // Saudacao("Rafa"); a string nome que colocamos na função saudação tem que ser colocada na main 
            // Saudacao(); também pode repetir a função várias vezes, para repetir na tela várias vezes, usando for ou while
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é o seu sobrenome?");
            string sobrenome = Console.ReadLine();
            
            Saudacao(nome, sobrenome);
            Console.WriteLine(MostrarHora());
            int hora = MostrarHora();
            Console.WriteLine($"{hora}h");

        }
        // da pra chamar mais de uma string na função, como o gibi e a pacoca abaixo. eles estao relacionados ao nome e sobrenome chamados na funcao main.   
        static void Saudacao(string pacoca, string gibi) { // o dotnet console ja executa a main sem ter que chama-lá, nossa classe não, ela tem que ser definida quando executar ela
            Console.WriteLine( $"Buon Pomeriggio {pacoca} {gibi} !! :D");
        }

          static int MostrarHora() { //pascal case, métodos (formas de escrita das funções e variáveis, com letra maiusculas e minúsculas)
            return DateTime.Now.Hour;
         }
    }

}
