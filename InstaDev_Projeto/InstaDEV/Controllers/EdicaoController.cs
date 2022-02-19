using System;
using System.Collections.Generic;
using System.IO;
using InstaDEV.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDEV.Controllers
{
    [Route("Edicao")]
    public class EdicaoController : Controller
    {
        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.NomeUsuario = HttpContext.Session.GetString("NomeUsuario");
            ViewBag.NomeCompleto = HttpContext.Session.GetString("NomeCompleto");
            ViewBag.FotoUsuario = HttpContext.Session.GetString("FotoPerfil");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            // ViewBag.UsuarioPerfil = usuarioModel.Deletar(Int32.Parse(HttpContext.Session.GetString("Id")));
            return View();
        }

        Usuario usuarioModel = new Usuario();

        // public IActionResult EditarFoto(IFormCollection form)
        // {
        //     Usuario fotoUsuario = new Usuario();
        //     fotoUsuario.Id = Int32.Parse(form["Id"]);

        //     // Upload

        //     if (form.Files.Count > 0)
        //     {
        //         var file = form.Files[0];
        //         var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/usuario");

        //         if (!Directory.Exists(folder))
        //         {
        //             Directory.CreateDirectory(folder);
        //         }

        //         var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", folder, file.FileName);

        //         using (var stream = new FileStream(path, FileMode.Create))
        //         {
        //             file.CopyTo(stream);
        //         }

        //         fotoUsuario.FotoPerfil = file.FileName;
        //     } else{
        //     }

        //     usuarioModel.Criar(fotoUsuario);

        //     ViewBag.Edicao = usuarioModel.ListarTodas();

        //     return LocalRedirect("~/Edicao/Listar");
        // }

        public IActionResult Alterar(IFormCollection form){

            List<Usuario> listaDeUsuario = usuarioModel.ListarTodas();
            Usuario novoUsuario = new Usuario();
            Usuario usuarioEncontrado = new Usuario();

            usuarioEncontrado = listaDeUsuario.Find(x => x.Email == form["Email"]);

                if (usuarioEncontrado == null)
                {
                    novoUsuario.Email = form["Email"];
                }

                usuarioEncontrado = listaDeUsuario.Find(x => x.NomeUsuario == form["NomeUsuario"]);

                 if (usuarioEncontrado == null)
                {
                    novoUsuario.NomeUsuario = form["NomeUsuario"];
                }

                usuarioEncontrado = listaDeUsuario.Find(x => x.NomeCompleto == form["NomeCompleto"]);

                if (usuarioEncontrado == null)
                {
                    novoUsuario.NomeCompleto = form["NomeCompleto"];
                }

            usuarioModel.Editar(novoUsuario);

            return LocalRedirect("~/Perfil/Listar");
        }

    
        [Route("Excluir")]
        public IActionResult Excluir(int id){
            // usuarioModel.Deletar(id);

            ViewBag.Edicao = usuarioModel.ListarTodas();

            return LocalRedirect("~/Cadastrar/Listar");
        }

    }
}