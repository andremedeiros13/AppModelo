﻿using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("Vendas")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
