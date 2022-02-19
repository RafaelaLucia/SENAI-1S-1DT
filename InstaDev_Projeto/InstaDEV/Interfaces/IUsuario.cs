using System.Collections.Generic;
using InstaDEV.Models;

namespace InstaDEV.Interfaces
{
    public interface IUsuario
    {
          string Preparar(Usuario u);

          void Criar(Usuario u);

          void Editar(Usuario u);

          void Deletar(int id);

          void Logar(Usuario u);

          List<Usuario> ListarTodas();
     
    }
}