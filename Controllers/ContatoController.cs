using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        
        
        public IActionResult Index()
        {
           var contatos =  _contatoRepositorio.BuscarTodos();
           return View(contatos);
        }
        
     
        public IActionResult Criar()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            _contatoRepositorio.Atualizar(contato);
            
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
        ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            
            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
     
    }
}