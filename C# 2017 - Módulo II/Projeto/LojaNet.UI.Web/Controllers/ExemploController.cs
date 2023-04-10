using LojaNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace LojaNet.UI.Web.Controllers
{
    public class ExemploController : Controller
    {
        // GET: Exemplo
        public ActionResult Index()
        {

            var cliente = new Cliente() { Id = "292829329", Nome = "José", Email = "jose@teste.com.br", Telefone = "93893349" };

            ViewBag.Dados1 = Tabela(cliente);


            var produto = new Produto() { Id = "kdss", Nome = "Caneta", Estoque = 10, Preco = 1000 };

            ViewBag.Dados2 = Tabela(produto);

            return View();
        }

        //
        //  <table> 
        //   <tr>
        //      <td>Nome: </td>
        //      <td>José da Silva </td>
        //  </tr>
        // </table>
        private string Tabela(object item)
        {
            var type = item.GetType();
            var props = type.GetProperties();
            var sb = new StringBuilder();
            sb.Append("<table class='table'>");
            foreach (var p in props)
            {
                sb.Append("<tr>");
                sb.Append("<td>");
                sb.Append(p.Name);
                sb.Append("</td>");
                sb.Append("<td>");
                sb.Append( p.GetValue(item).ToString() );
                sb.Append("</td>");
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            return sb.ToString();

        }
    }
}