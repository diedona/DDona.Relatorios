using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDona.Relatorios.Web.ViewModel.DataTables
{
    public class DatatablesColumnModel
    {
        public string data { get; set; }
        public string name { get; set; }
        public bool searchable { get; set; }
        public bool orderable { get; set; }
        public DatatablesColumnSearchModel search { get; set; }
    }
}