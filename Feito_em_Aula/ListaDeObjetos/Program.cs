using System;
using System.Collections.Generic; //usar esse system se não o list não é reconhecido, igual nas classes
using ListaDeObjetos.Classes;

namespace ListaDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
             // CRUD - Create, Read, Update, Delete
             // CRUD são as operações básicas feitas num sistema (de orientação objeto)
 
            List<Produto> produtos = new List<Produto>();
            
            // Crud - Create:
            // Adicionando usando o método construtor de produto, visto na aula anterior
            produtos.Add( new Produto(1, "Apple Watch", 3522.56f) );
            produtos.Add( new Produto(2, "Xiaomi Watch", 1522.47f) );
            produtos.Add( new Produto(3, "Zenfone ASUS", 1198.47f) );
            produtos.Add( new Produto(4, "Samsung S20", 3749.00f) );
            produtos.Add( new Produto(5, "Motorola G8", 1799.10f) );

            // Crud - Create:
            // outra forma de fazer, instanciando com o método construtor simples
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "iphone 12";
            iphone.Preco = 9552.40f;
            
            produtos.Add(iphone);


            // Crud - Read:
            //Exibir o conteúdo da lista
             Console.WriteLine("\nLista de Produtos");
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Codigo} {item.Nome} - R$ {item.Preco}");
            }
                Console.WriteLine("\n");
            
            // Crud - Delete:
            // Remove o item do índice 6
            produtos.RemoveAt(5);
            // removo todos os itens que se adequam na expressao lambda
            produtos.RemoveAll(item => item.Nome == "Apple Watch" && item.Preco > 3000);
            // vou deixar o delete aqui pra seguir a ordem, mas o delete só vai funcionar antes do read
            
            // Crud - Update:
            // eu quero encontrar e atualizar um produto chamado samsung s20, pelo codigo, neste caso
            Produto atualizar = produtos.Find(item => item.Codigo == 4);
            // muda o valor do produto
            atualizar.Preco = 1200.47f;

            // remove o item antigo
            produtos.RemoveAll(item => item.Codigo == 4);
             
            // inserir o item tualizado
            produtos.Insert(3, atualizar);

            Console.WriteLine("Lista de produtos com Delete e Update");
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Codigo} {item.Nome} - R$ {item.Preco}");
                //iphones deletados e preço do samsung alterado
            }


        }
    }
}
