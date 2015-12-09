using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.DTO.DataTables
{
    public class DatatablesModelDTO
    {
        public int draw { get; set; }
        public List<DatatablesColumnModelDTO> columns { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<DatatablesOrderModelDTO> order { get; set; }
        public DatatablesColumnSearchModelDTO search { get; set; }
    }
}
