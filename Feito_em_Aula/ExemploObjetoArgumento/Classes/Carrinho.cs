using System.Collections.Generic;
using System;
namespace ExemploObjetoArgumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }        

        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }

        public void MostrarProdutos(){
            if (carrinho != null)
            {
            foreach (Produto p in carrinho)
            {
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine($"{p.Preco:C2} - {p.Nome}");
              Console.ResetColor();
            }   
            }
        }        
        
        public void MostrarTotal(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco; // mesma coisa que "ValorTotal = ValorTotal + p.Preco;"
                }
                Console.WriteLine($"Total do Carrinho {ValorTotal:C2}");
            } else
            {
                Console.WriteLine("Seu carrinho está vazio!");
            }
            Console.ResetColor();
        }

        public void AlterarItem(int _codigo, Produto novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = novoProduto.Nome;

            foreach (Produto x in carrinho)
            {
                if (x.Codigo == _codigo) //(cadaItem.Codigo == _codigo
                {
                  x.Nome = novoProduto.Nome;                    
                }
            }
        }   // foreach, ler toda lista, mas le só linha por linha. foreach pega so a primeira linha e avalia, tem o produto com codigo nome e preco, para especificar que ele veja o codigo desse produto em especifico, temq eu dizer "cada item que vc pegar le apenas o codigo para comparar" entao o x na verdade simboliza cada linha que ele esta olhando, mas poderia ser qualquer coisa no lugar do x
    }
}