using DDona.Relatorios.Business;
using DDona.Relatorios.DTO.DataTables;
using DDona.Relatorios.DTO.Loja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DDona.Relatorios.Wcf.Loja
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Loja" in both code and config file together.
    public class Loja : ILoja
    {
        public LojaDatatablesResponseDTO GetRelatorioPaginadoDatatables(DatatablesModelDTO DatatablesModel)
        {
            LojaService LojaService = new LojaService();
            return LojaService.GetRelatorioPaginadoDatatables(DatatablesModel);
        }
    }
}
