using Microsoft.AspNetCore.Mvc;
using LojaNet.Models;
using LojaNet.BLL;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		// Incluir
		public ActionResult Incluir()
		{
			var cli = new Cliente();
			return View(cli);
		}


		// Incluir  (post)
		[HttpPost]
		public ActionResult Incluir(Cliente cliente)
		{
			try
			{
				var bll = new ClienteBLL();
				bll.Incluir(cliente);
				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				ModelState.AddModelError(string.Empty, ex.Message);
				return View(cliente);
			}
		}

	}
}
