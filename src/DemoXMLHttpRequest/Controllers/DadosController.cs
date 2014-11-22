using DemoXMLHttpRequest.Models;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;

namespace DemoXMLHttpRequest.Controllers
{
    public class DadosController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CliJson()
        {
            System.Threading.Thread.Sleep(3000);
            return Json(Clientes.ListaDeClientes, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CliXML()
        {
            var dados = Clientes.ListaDeClientes;

            //var xmlLINQ = new XElement("Clientes",
            //    from cli in dados
            //    select new XElement("Cliente",
            //                    new XAttribute("ID", cli.ID),
            //                    new XElement("Nome", cli.Nome)
            //               ));

            var xmlLambda = new XElement("Clientes", dados.Select(cli => new XElement("Cliente",
                                new XAttribute("ID", cli.ID),
                                new XAttribute("Nome", cli.Nome)
                                //new XElement("Nome", cli.Nome),
                           )));
            System.Threading.Thread.Sleep(3000);
            return Content(xmlLambda.ToString(), "text/xml");
        }


    }
}