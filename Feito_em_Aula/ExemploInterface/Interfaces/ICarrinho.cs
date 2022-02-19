using ExemploInterface.Classes;

namespace ExemploInterface.Interfaces
{
    public interface ICarrinho
    {
        
        void Cadastrar(Produto produto);

        void Alterar(int _codigo, Produto produto);
void Listar(); 
        void Deletar(Produto produto);
    }
}