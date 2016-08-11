using _3PSoft.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3PSoft.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepositorio _repositorioProduto;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorioProduto = new ProdutoRepositorio();
            var produtos = _repositorioProduto.Produtos.Take(10);

            return View(produtos);
        }
    }
}