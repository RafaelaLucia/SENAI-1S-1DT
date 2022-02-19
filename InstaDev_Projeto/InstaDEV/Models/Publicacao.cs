using System.Collections.Generic;
using System.IO;
using InstaDEV.Interfaces;

namespace InstaDEV.Models
{
    public class Publicacao : InstaDevbase, IPublicacao
    {
        public string imagem { get; set; }

        public int idUsuario { get; set; }

        public int idPublicacao { get; set; }      
        public string nomeDeUsuario { get; set; }

        public string fotoUsuario { get; set; }

        public string legendaPublicacao { get; set; }
        private const string CAMINHO = "Database/Publicacao.csv";

        public Publicacao()
        {
            CriarPastaArquivo(CAMINHO);
        }

        public string Preparar(Publicacao p)
        {
            return $"{p.legendaPublicacao};{p.imagem};{p.idUsuario};{p.idPublicacao};{p.fotoUsuario};{p.nomeDeUsuario}";
        }

        public void CriarPublicacao(Publicacao p)
        {
            string[] linha = { Preparar(p) };
            File.AppendAllLines(CAMINHO, linha);
        }

        public void DeletarPublicacao(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Publicacao> ListarPublicacao()
        {
            List<Publicacao> publicacaos = new List<Publicacao>();
            Usuario usuario = new Usuario();

            string[] linhas = File.ReadAllLines(CAMINHO);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Publicacao post = new Publicacao();
                post.legendaPublicacao = linha[0];
                post.imagem = linha[1];

                publicacaos.Add(post);
            }
            return publicacaos;
        }

        public List<Publicacao> ListarPublicacaoPerfil(int Id)
        {
            List<Publicacao> publicacaos = new List<Publicacao>();

            string[] linhas = File.ReadAllLines(CAMINHO);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                if (linha[2] == Id.ToString())
                {
                Publicacao post = new Publicacao();
                post.legendaPublicacao = linha[0];
                post.imagem = linha[1];
                publicacaos.Add(post);
                }
            }
            return publicacaos;
        }

           public List<Usuario> ListarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario= new Usuario();

            string[] linhas = File.ReadAllLines(CAMINHO);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Usuario u = new Usuario();
                u.FotoPerfil = linha[5];
                u.NomeUsuario = linha[4];
         
                usuarios.Add(u);
            }
            return usuarios;
        }
    }

}