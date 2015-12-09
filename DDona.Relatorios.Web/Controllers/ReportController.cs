using DDona.Relatorios.Web.LojaReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDona.Relatorios.Web.Controllers
{
    public class ReportController : Controller
    {
        public ActionResult Report1()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Report1(DatatablesModelDTO DatatablesModel)
        {
            using(LojaReference.LojaClient LojaClient = new LojaReference.LojaClient())
            {
                return Json(LojaClient.GetRelatorioPaginadoDatatables(DatatablesModel));
            }
        }
    }
}