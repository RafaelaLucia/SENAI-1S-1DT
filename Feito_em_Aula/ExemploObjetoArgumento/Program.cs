﻿using System;
using ExemploObjetoArgumento.Classes;

namespace ExemploObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            Produto p1 = new Produto(1, "Red Dead Redemption 2", 500.40f);
            Produto p2 = new Produto(2, "Grand Theft Auto V", 56.90f);
            Produto p3 = new Produto(3, "Detroit Become Human", 120.50f);
            Produto p4 = new Produto(4, "Celeste" , 22.99f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);
            
            carrinho.MostrarProdutos();
            carrinho.MostrarTotal();
        }
    }
}
