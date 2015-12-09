using DDona.Relatorios.DataAccess;
using DDona.Relatorios.DTO.DataTables;
using DDona.Relatorios.DTO.Loja;
using DDona.Relatorios.SqlBuilder.Loja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.Business
{
    public class LojaService
    {
        public LojaDatatablesResponseDTO GetRelatorioPaginadoDatatables(DatatablesModelDTO DatatablesModel)
        {
            LojaSQLBuilder LojaSQLBuilder = new LojaSQLBuilder();
            CustomAccess CustomAccess = new CustomAccess();

            ReturnSQL ReturnSQL = null;
            List<LojaDTO> Lojas = null;
            int QuantidadeRegistros = 0;

            #region CARREGANDO OS DADOS PAGINADOS
            ReturnSQL = LojaSQLBuilder.GetRelatorioLoja(DatatablesModel);

            try
            {
                Lojas = CustomAccess.Get<LojaDTO>(ReturnSQL);
            }
            catch (Exception)
            {
                Lojas = new List<LojaDTO>();
            } 
            #endregion

            #region CARREGANDO O TOTAL DE DADOS (SEM FILTRO)
            ReturnSQL = null;
            ReturnSQL = LojaSQLBuilder.GetRelatorioLojaCount(false);

            try
            {
                QuantidadeRegistros = CustomAccess.Get<int>(ReturnSQL).FirstOrDefault();
            }
            catch (Exception) 
            { 
                QuantidadeRegistros = 0; 
            }
            #endregion

            #region CONFIGURAÇÃO OBJETO DE RETORNO
            LojaDatatablesResponseDTO ModelResponse = new LojaDatatablesResponseDTO();
            ModelResponse.draw = DatatablesModel.draw;
            ModelResponse.data = Lojas;
            ModelResponse.recordsFiltered = QuantidadeRegistros;
            ModelResponse.recordsTotal = QuantidadeRegistros;
            #endregion
            
            return ModelResponse;
        }
    }
}
