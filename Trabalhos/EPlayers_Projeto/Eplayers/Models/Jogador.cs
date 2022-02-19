using System;
using System.Collections.Generic;
using System.IO;
using Eplayers.Interfaces;

namespace Eplayers.Models
{
    public class Jogador :  EPlayersBase, IJogador
    {
       public int IdJogador { get; set; }
       public string Nome { get; set; }
       public int IdEquipe { get; set; }
       public string Email { get; set; }
       public string Senha { get; set; }
       private const string CAMINHO = "DataBase/Jogador.csv"; 

       public Jogador(){
        CriarPastaEArquivo(CAMINHO);
       }
        private string PrepararLinha(Jogador j){
           return $"{j.IdJogador}; {j.Nome}; {j.IdEquipe}; {j.Email}; {j.Senha};";
       }
        public void Alterar(Jogador j)
        {
           List<string> linhas = LerTodasLinhascsv(CAMINHO);
           linhas.RemoveAll(x => x.Split(";")[0] == j.IdJogador.ToString());
           linhas.Add(PrepararLinha(j));
           RescreverCSV(CAMINHO, linhas);
        }

        public void Criar(Jogador j)
        {
            string[] linha = {PrepararLinha(j)};
            File.AppendAllLines(CAMINHO, linha);
        }

        public void Deletar(int id)
        {
           List<string> linhas = LerTodasLinhascsv(CAMINHO);
           linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
           RescreverCSV(CAMINHO, linhas);
        }

        public List<Jogador> LerTodas()
        {
           List<Jogador> jogadores = new List<Jogador>();

            string[] linhas = File.ReadAllLines(CAMINHO);
           
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                
                Jogador novoJogador = new Jogador();
                novoJogador.IdJogador = Int32.Parse(linha[0]);
                novoJogador.Nome = linha[1];
                novoJogador.IdEquipe = int.Parse(linha[2]);
                novoJogador.Email = linha[3];
                novoJogador.Senha = linha[4];
            
                jogadores.Add(novoJogador);  
            } 
                return jogadores;       
        }
    }
}