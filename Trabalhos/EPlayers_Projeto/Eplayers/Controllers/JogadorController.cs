using System;
using Eplayers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eplayers.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        Jogador jogadorModel = new Jogador();

        [Route("Listar")]
        public IActionResult Index(){
            ViewBag.Jogadores = jogadorModel.LerTodas();
            return View();
        }     

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form){
            Jogador novoJogador = new Jogador();
            novoJogador.IdJogador = Int32.Parse(form["IdJogador"]);
            novoJogador.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novoJogador.Nome = form["Nome"];
            novoJogador.Email = form["Email"];
            novoJogador.Senha = form["Senha"];

            jogadorModel.Criar(novoJogador);
            ViewBag.Jogadores = jogadorModel.LerTodas();

            return LocalRedirect("~/Jogador/Listar");
        }  
 
    [Route("Excluir/{id}")]
    public IActionResult Excluir(int id){
      jogadorModel.Deletar(id);
      ViewBag.Jogador = jogadorModel.LerTodas();
      return LocalRedirect("~/Jogador/Listar");
    }  
    }
}