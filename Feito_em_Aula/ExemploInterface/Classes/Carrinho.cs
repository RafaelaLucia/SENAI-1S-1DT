using ExemploInterface.Interfaces;
using System;
using System.Collections.Generic;

namespace ExemploInterface.Classes
{
    public class Carrinho : ICarrinho //Carrinho : Produto, ICarrinho ; classe antes da interface
    {

        public float ValorTotal { get; set; }
        
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }
        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);  //da pra acrescentar coisas mas não faltar
        }

        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
               Console.WriteLine($"{item.Preco:C2} - {item.Nome}");   
            }
        }
    }
}