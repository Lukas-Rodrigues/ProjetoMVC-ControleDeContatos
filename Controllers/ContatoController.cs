using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        
     
        public IActionResult Criar()
        {
           return View();
        }
        
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
     
    }
}