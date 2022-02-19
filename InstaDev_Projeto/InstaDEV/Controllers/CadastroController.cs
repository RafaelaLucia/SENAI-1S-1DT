using System;
using System.Collections.Generic;
using InstaDEV.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDEV.Controllers
{
    [Route("Cadastrar")]
    public class CadastroController : Controller
    {
        Usuario usuarioModel = new Usuario();

        [TempData]
        public string mensagemErro { get; set; }

        [TempData]
        public string mensagemErroNick { get; set; }
        

     [Route("Listar")]

      public IActionResult Index()
        {
            return View();
        }
        
            public IActionResult Cadastrar(IFormCollection form){

            List<Usuario> listaDeUsuario = usuarioModel.ListarTodas();
            Usuario novoUsuario = new Usuario();
            Random idRandom = new Random();
            Usuario usuarioEncontrado = new Usuario();

            do
            {
                int novoId = idRandom.Next(999999);
                usuarioEncontrado = listaDeUsuario.Find(x => x.Id == novoId);

                if (usuarioEncontrado == null)
                {
                    novoUsuario.Id = novoId;
                }

            } while (usuarioEncontrado != null);

            usuarioEncontrado = listaDeUsuario.Find(x => x.Email == form["Email"]);

                if (usuarioEncontrado == null)
                {
                    novoUsuario.Email = form["Email"];
                } else{

                    mensagemErro = "Email já cadastrado";
                    return LocalRedirect("~/Cadastrar/Listar");
                }

                usuarioEncontrado = listaDeUsuario.Find(x => x.NomeUsuario == form["NomeUsuario"]);

                 if (usuarioEncontrado == null)
                {
                    novoUsuario.NomeUsuario = form["NomeUsuario"];
                } else{

                    mensagemErroNick = "Este nome já está sendo usado";
                    return LocalRedirect("~/Cadastrar/Listar");
                }

            novoUsuario.FotoPerfil = "padrao.jpg";
            novoUsuario.Senha = form["Senha"];
            novoUsuario.NomeCompleto = form["NomeCompleto"];

            usuarioModel.Criar(novoUsuario);

            return LocalRedirect("~/");

        }
    }
}
    
