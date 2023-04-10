using System;
using System.Web.Mvc;
using LojaNet.Models;

namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteDados bll;

        //
        // Construtor
        //
        public ClienteController()
        {
            bll = AppContainer.ObterClienteBLL();
        }

        //
        // Excluir
        //
        public ActionResult Excluir(string id)
        {
            var cliente = bll.ObterPorId(id);
            return View(cliente);
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
                var cliente = bll.ObterPorId(id);
                return View(cliente);
            }

        }

        //
        // Alterar
        //
        public ActionResult Alterar(string id)
        {
            var cliente = bll.ObterPorId(id);
            return View(cliente);
        }

        //
        // Alterar (post)
        //
        [HttpPost]
        public ActionResult Alterar(Cliente cliente)
        {
            try
            {

                bll.Alterar(cliente);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(cliente);
            }
        }



        //
        // Detalhes
        //
        public ActionResult Detalhes(string id)
        {
            var cliente = bll.ObterPorId(id);
            return View(cliente);
        }


        //
        // Incluir
        //
        public ActionResult Incluir()
        {
            var cli = new Cliente();
            return View(cli);
        }

        //
        // Incluir  (post)
        //
        [HttpPost]
        public ActionResult Incluir(Cliente cliente)
        {
            try
            {
                
                bll.Incluir(cliente);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(cliente);
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