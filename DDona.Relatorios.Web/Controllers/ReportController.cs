using DDona.Relatorios.Web.LojaReference;
using DDona.Relatorios.Web.ViewModel.PDF;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public ActionResult Report2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Report2(int QtdItens)
        {
            Debug.WriteLine("{0} - Comecei a gerar dados", DateTime.Now);
            List<PdfFakeResult> Data = GenerateFakeData(QtdItens);
            Debug.WriteLine("{0} - Terminei de gerar dados", DateTime.Now);
            ViewAsPdf Pdf = new ViewAsPdf("Report2PartialPdf", Data);
            Pdf.FileName = "Report2.pdf";
            Debug.WriteLine("{0} - Retornando o Download", DateTime.Now);

            return Pdf;
        }

        private List<PdfFakeResult> GenerateFakeData(int QtdItens)
        {
            List<PdfFakeResult> Data = new List<PdfFakeResult>(QtdItens);

            for (int i = 0; i < QtdItens; i++)
            {
                Data.Add(GenerateFakeDataItem(i));
            }

            return Data;
        }

        private PdfFakeResult GenerateFakeDataItem(int Index)
        {
            return new PdfFakeResult()
            {
                DataNascimento = new DateTime(2000,12,15),
                Estado = "SP",
                GrauInvestimento = "AAA+",
                Nome = "José Almeida",
                Saldo = 1500.5m
            };
        }
    }
}