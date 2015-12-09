using DDona.Relatorios.DTO.DataTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.DTO.Loja
{
    public class LojaDatatablesResponseDTO : DatatablesResponseModelDTO<LojaDTO>
    {
        public override List<LojaDTO> data { get; set; }
    }
}
