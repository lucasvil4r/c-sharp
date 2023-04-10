using System;
using System.Web.Mvc;
using LojaNet.Models;

namespace LojaNet.UI.Web.Controllers
{

    
    public class ProdutoController : Controller
    {
        private IProdutoDados bll;

        //
        // Construtor
        //
        public ProdutoController()
        {
            bll = AppContainer.ObterProdutoBLL();
        }

        //
        // Excluir
        //
        public ActionResult Excluir(string id)
        {
            var produto = bll.ObterPorId(id);
            return View(produto);
        }

        //
        // Excluir (post)
        //
        [HttpPost]
        public ActionResult Excluir(string id, FormCollection form)
        {
            try
            {
                bll.Excluir(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                var produto = bll.ObterPorId(id);
                return View(produto);
            }

        }

        //
        // Alterar
        //
        public ActionResult Alterar(string id)
        {
            var produto = bll.ObterPorId(id);
            return View(produto);
        }


        //
        // Alterar (post)
        //
        [HttpPost]
        public ActionResult Alterar(Produto produto)
        {
            try
            {

                bll.Alterar(produto);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(produto);
            }
        }

        //
        // Detalhes
        //
        public ActionResult Detalhes(string id)
        {
            var produto = bll.ObterPorId(id);
            return View(produto);
        }


        //
        // Incluir
        //
        public ActionResult Incluir()
        {
            var prod = new Produto();
            return View(prod);
        }

        //
        // Incluir (post)
        //
        [HttpPost]
        public ActionResult Incluir(Produto produto)
        {
            try
            {
                
                bll.Incluir(produto);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(produto);
            }
        }

        //
        // Index
        //
       
        public ActionResult Index()
        {
            var lista = bll.ObterTodos();
            return View(lista);
        }

    }
}