using System.Collections.Generic;
using Eplayers.Models;

namespace Eplayers.Interfaces
{
    public interface IEquipe
    {
        void Criar (Equipe e);
        List<Equipe> LerTodas();
        void Alterar(Equipe e);
        void Deletar (int id);
    }
}