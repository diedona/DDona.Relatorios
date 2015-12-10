using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDona.Relatorios.Web.ViewModel.PDF
{
    public class PdfFakeResult
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Estado { get; set; }
        public string GrauInvestimento { get; set; }
        public decimal Saldo { get; set; }
    }
}