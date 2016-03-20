using Aplicacao;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApresentacaoMVC.Controllers
{
    public class ProdutoController : Controller
    {

        ProdutoAplicacao appProduto;

        public ProdutoController()
        {
            appProduto = new ProdutoAplicacao();
        }

        public ActionResult Index()
        {
            var lista = appProduto.Listar();
            return View(lista);
        }

        public ActionResult Details(int id)
        {
            var produto = appProduto.RetornaPorId(id);
            return View(produto);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appProduto.Salvar(produto);
                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch
            {
                return View(produto);
            }
        }

        public ActionResult Edit(int id)
        {
            var produto = appProduto.RetornaPorId(id);
            return View(produto);
        }

        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appProduto.Alterar(produto);
                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch
            {
                return View(produto);
            }
        }

        public ActionResult Delete(int id)
        {
            var produto = appProduto.RetornaPorId(id);
            return View(produto);
        }

        [HttpPost]
        public ActionResult Delete(Produto produto)
        {
            try
            {
                appProduto.Excluir(produto.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GetListaListaDeProdutos()
        {
            var lista = appProduto.Listar();
            return PartialView("_ListaDeProdutos", lista);
        }
    }
}
