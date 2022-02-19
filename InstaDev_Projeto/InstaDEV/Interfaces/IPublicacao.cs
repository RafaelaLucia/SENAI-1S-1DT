using System.Collections.Generic;
using InstaDEV.Models;

namespace InstaDEV.Interfaces
{
    public interface IPublicacao 
    {
         void CriarPublicacao(Publicacao p);

         List<Publicacao> ListarPublicacao();

         void DeletarPublicacao(int id);
    }
    
}