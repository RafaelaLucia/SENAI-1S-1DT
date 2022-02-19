using System;
using ExemploMetodoConstrutores.Classes;

namespace ExemploMetodoConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExemplo de Métodos Construtores");

            Produtos p = new Produtos();
            p.Nome = "Tomate"; //se só tem get vc n pode mudar o nome aqui, se so tiver set, nao é possivel mostrar, exibir ele no programa e no terminal.
            Console.WriteLine($"Primeiro Produto (Construtor sem argumentos)");
            Console.WriteLine($"Codigo: {p.Codigo}\nNome: {p.Nome}\nDescrição: {p.Descricao}\nNumero de itens no estoque: {p.Estoque}\n");

            Produtos p2 = new Produtos(456);
            Console.WriteLine($"Segundo Produto (Construtor com 1 argumento)");
            Console.WriteLine($"Codigo: {p2.Codigo}\nNome: {p2.Nome}\nDescrição: {p2.Descricao}\nNumero de itens no estoque: {p2.Estoque}\n");

            Produtos p3 = new Produtos(678, "Maçã", "Maçã bonita sem agrotóxicos", 3);
            Console.WriteLine($"Terceiro Produto (Construtor com 4 argumentos)");
            Console.WriteLine($"Codigo: {p3.Codigo}\nNome: {p3.Nome}\nDescrição: {p3.Descricao}\nNumero de itens no estoque: {p3.Estoque}\n");
            // é um método que tem um mesmo nome da classe e utilizamos sobrecarga para ter tres metodos com 3 comportamentos diferentes, é tipo um polimorfismo na instância da classe
        
        }
    }
}
