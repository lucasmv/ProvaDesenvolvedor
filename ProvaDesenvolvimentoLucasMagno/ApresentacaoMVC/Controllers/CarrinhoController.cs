using Aplicacao;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApresentacaoMVC.Controllers
{
    public class CarrinhoController : Controller
    {

        public static CarrinhoAplicacao appCarrinho = new CarrinhoAplicacao();

        ProdutoAplicacao appProduto;

        public CarrinhoController()
        {
            appProduto = new ProdutoAplicacao();
        }       

        public ActionResult Index()
        {
            ViewBag.Total = appCarrinho.RetornaTotal();
            return View(appCarrinho.getCarrinho());
        }

        [HttpPost]
        public JsonResult AdicionaProduto(Produto produto)
        {
            var produtoAdicionar = appProduto.RetornaPorId(produto.Id);
            produtoAdicionar.Quantidade = produto.Quantidade;

            appCarrinho.Adiciona(produtoAdicionar);
            return Json("Pruduto adicionado com sucesso!");
        }


        public ActionResult ZerarCarrinho()
        {
            appCarrinho.ZerarCarrinho();

            return RedirectToAction("Index");
        }
    }
}