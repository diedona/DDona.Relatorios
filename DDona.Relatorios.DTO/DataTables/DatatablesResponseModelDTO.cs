using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.DTO.DataTables
{
    public abstract class DatatablesResponseModelDTO<T> where T: class
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public abstract List<T> data { get; set; }
    }
}
