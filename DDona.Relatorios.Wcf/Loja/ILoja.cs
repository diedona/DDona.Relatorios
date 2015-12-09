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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoja" in both code and config file together.
    [ServiceContract]
    public interface ILoja
    {
        [OperationContract]
        LojaDatatablesResponseDTO GetRelatorioPaginadoDatatables(DatatablesModelDTO DatatablesModel);
    }
}
