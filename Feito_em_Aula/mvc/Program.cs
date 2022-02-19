using System;
using mvc.Controllers;
using mvc.Models;

namespace mvc
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController prodcr = new ProdutoController();

           prodcr.Cadastrar();     

           prodcr.ListarProdutos(); 
        }
    }
}
