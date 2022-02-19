using System.Collections.Generic;
using System.IO;
using System;
using InstaDEV.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDEV.Controllers
{
        [Route("Feed")]
    public class FeedController : Controller
    {
        Publicacao publicacaoModel = new Publicacao();
        Usuario usuarioModel = new Usuario();


        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Publicacao = publicacaoModel.ListarPublicacao();
            ViewBag.Usuario = usuarioModel.ListarTodas();
            ViewBag.NomeUsuario = HttpContext.Session.GetString("NomeUsuario");
            ViewBag.NomeCompleto = HttpContext.Session.GetString("NomeCompleto");
            ViewBag.FotoUsuario = HttpContext.Session.GetString("FotoPerfil");
            return View();
        }

        public IActionResult CadastrarPost(IFormCollection form){
            Publicacao novaPublicacao = new Publicacao();
            Usuario usuarinho = new Usuario();
            // novaPublicacao.nomeDeUsuario = form["nomeDeUsuario"];
            // novaPublicacao.nome = form["nome"];
            usuarinho.NomeUsuario = form["NomeUsuario"];
            novaPublicacao.legendaPublicacao = form["legendaPublicacao"];

            novaPublicacao.idUsuario = Int32.Parse(HttpContext.Session.GetString("Id"));
            novaPublicacao.fotoUsuario = HttpContext.Session.GetString("FotoPerfil");
            novaPublicacao.nomeDeUsuario = HttpContext.Session.GetString("NomeUsuario");

            List<Publicacao> listaDePublicacao = publicacaoModel.ListarPublicacao();
            Random idRandom = new Random();
            Publicacao publicacaoEncontrada = new Publicacao();

            do
            {
                int novoId = idRandom.Next(999999);
                publicacaoEncontrada = listaDePublicacao.Find(x => x.idPublicacao == novoId);

                if (publicacaoEncontrada == null)
                {
                    novaPublicacao.idPublicacao = novoId;
                }

            } while (publicacaoEncontrada != null);
            
            // novaEquipe.Imagem = form["Imagem"];

            // Upload

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imgPubli/Posts");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imgPubli/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaPublicacao.imagem = file.FileName;
            
            }
            publicacaoModel.CriarPublicacao(novaPublicacao);

            ViewBag.Publicacao = publicacaoModel.ListarPublicacao();
            return LocalRedirect("~/Feed/Listar");
        }
    }
}