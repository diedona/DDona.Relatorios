using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.DTO.Loja
{
    public class LojaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Nota { get; set; }
        public decimal? Investimento { get; set; }
    }
}
