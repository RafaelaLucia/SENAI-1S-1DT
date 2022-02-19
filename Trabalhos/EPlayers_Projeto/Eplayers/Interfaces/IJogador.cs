using System.Collections.Generic;
using Eplayers.Models;

namespace Eplayers.Interfaces
{
    public interface IJogador
    {
       void Criar (Jogador j);
        List<Jogador> LerTodas();
        void Alterar(Jogador j);
        void Deletar (int id);  
    }
}