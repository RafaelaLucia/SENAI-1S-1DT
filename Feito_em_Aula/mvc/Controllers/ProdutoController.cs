using System.Collections.Generic;
using mvc.Models;
using mvc.Views;

namespace mvc.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoview = new ProdutoView();
        
        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();
            produtoview.Listar(produtos);
            // produtoview.Listar(produto.Ler()); da pra escrever assim tbm
        }

        public void Cadastrar(){
          Produto produto = produtoview.CadastrarProduto();
          produto.Inserir(produto);
        //   produto.Inserir(produtoview.CadastrarProduto()); assim tambem funciona
        }
    }
}