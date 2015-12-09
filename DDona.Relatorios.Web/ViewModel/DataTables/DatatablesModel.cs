using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDona.Relatorios.Web.ViewModel.DataTables
{
    public class DatatablesModel
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<DatatablesOrderModel> order { get; set; }
        public DatatablesColumnSearchModel search { get; set; }
    }
}