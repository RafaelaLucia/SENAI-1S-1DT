using System.Collections.Generic;
using InstaDEV.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDEV.Controllers
{
    public class LoginController : Controller
    {
        [TempData]
        public string Mensagem { get; set; }


        Usuario usuarioModel = new Usuario();

        // [Route("Listar")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]

        public IActionResult Logar(IFormCollection form)
        {

            List<string> UsuariosCSV = usuarioModel.LerTodasLinhasCSV("Database/Usuario.csv");

            var logado = UsuariosCSV.Find(
                x =>
                x.Split(";")[0] == form["Email"] &&
                x.Split(";")[1] == form["Senha"]
            );

            if (logado != null)
            {
                HttpContext.Session.SetString("Email", logado.Split(";")[0]);
                HttpContext.Session.SetString("Id", logado.Split(";")[2]);
                HttpContext.Session.SetString("NomeCompleto", logado.Split(";")[3]);
                HttpContext.Session.SetString("NomeUsuario", logado.Split(";")[4]);
                HttpContext.Session.SetString("FotoPerfil", logado.Split(";")[5]);
                return LocalRedirect("~/Feed/Listar");

            }
            Mensagem = "Dados incorretos, tente novamente!";
            return LocalRedirect("~/");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("NomeUsuario");
            return LocalRedirect("~/");
        }
    }
}