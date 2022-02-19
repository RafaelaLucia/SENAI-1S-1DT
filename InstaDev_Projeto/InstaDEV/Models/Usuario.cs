using System;
using System.Collections.Generic;
using System.IO;
using InstaDEV.Interfaces;

namespace InstaDEV.Models
{
    public class Usuario : InstaDevbase, IUsuario
    {
         public string Email { get; set; }
        public string Senha { get; set; }
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeUsuario { get; set; }
        public string FotoPerfil { get; set; }

        private const string CAMINHO = "Database/Usuario.csv";

        public Usuario()
        {
            CriarPastaArquivo(CAMINHO);
        }
        
        public string Preparar(Usuario u)
        {
            return $"{u.Email};{u.Senha};{u.Id};{u.NomeCompleto};{u.NomeUsuario};{u.FotoPerfil}";
        }

        public void Criar(Usuario u)
        {
            string[] linha = {Preparar(u)};
            File.AppendAllLines(CAMINHO,linha);
        }

        public void Editar(Usuario u)
        {
           List<string> linhas = LerTodasLinhasCSV(CAMINHO);

            linhas.RemoveAll(x => x.Split(";")[0] == u.Email);
            // linhas.RemoveAll(x => x.Split(";")[2] == u.Id.ToString());
            linhas.RemoveAll(x => x.Split(";")[3] == u.NomeCompleto);
            linhas.RemoveAll(x => x.Split(";")[4] == u.NomeUsuario);
            linhas.Add(Preparar(u));
            ReescreverCSV(CAMINHO, linhas);
        }

        public void Deletar(int id)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);

            linhas.RemoveAll(x => x.Split(";")[2] == id.ToString());
            ReescreverCSV(CAMINHO, linhas);
        
        }

        public void Logar(Usuario u)
        {
            throw new System.NotImplementedException();
        }

        public List<Usuario> ListarTodas()
        {
             List<Usuario> usuarios = new List<Usuario>();

            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Usuario usuario = new Usuario();
                usuario.Email = linha[0];
                usuario.Senha = linha[1];
                usuario.Id = Int32.Parse(linha[2]);
                usuario.NomeCompleto = linha[3];
                usuario.NomeUsuario = linha[4];

                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public List<Usuario> ListarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Usuario usuario = new Usuario();
                usuario.FotoPerfil = linha[5];
                usuario.NomeUsuario = linha[4];

                usuarios.Add(usuario);
            }

            return usuarios;
        }

         public int RetornaId() {
           return Id;
    }

    public string RetornaNome(){
        return NomeUsuario;
    }
    
  }
}