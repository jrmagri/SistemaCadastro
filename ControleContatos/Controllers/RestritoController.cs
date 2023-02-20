using ControleContatos.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Controllers
{
    public class RestritoController : Controller
    {
        [PaginaDoUsuarioLogado]
        public IActionResult Index()
        {
            return View();
        }
    }
}
