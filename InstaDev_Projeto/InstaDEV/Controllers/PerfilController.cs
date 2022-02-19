using System;
using InstaDEV.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDEV.Controllers
{
        [Route("Perfil")]
    public class PerfilController : Controller
    {

        Publicacao postagemModel = new Publicacao();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.NomeUsuario = HttpContext.Session.GetString("NomeUsuario");
            ViewBag.NomeCompleto = HttpContext.Session.GetString("NomeCompleto");
            ViewBag.FotoUsuario = HttpContext.Session.GetString("FotoPerfil");
            ViewBag.PublicacaoPerfil = postagemModel.ListarPublicacaoPerfil(Int32.Parse(HttpContext.Session.GetString("Id")));
            return View();
        }

        public IActionResult ListarPostagem(){
            ViewBag.PublicacaoPerfil = postagemModel.ListarPublicacaoPerfil(Int32.Parse(HttpContext.Session.GetString("Id")));
            return LocalRedirect("~/Perfil/Listar");
        }
    }
}