using DDona.Relatorios.DataAccess;
using DDona.Relatorios.DTO.DataTables;
using DDona.Relatorios.SqlBuilder.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.SqlBuilder.Loja
{
    public class LojaSQLBuilder
    {
        private LojaSQLContainer _sqlContainer = null;

        public LojaSQLBuilder()
        {
            _sqlContainer = new LojaSQLContainer();
        }

        public ReturnSQL GetRelatorioLoja(DatatablesModelDTO DatatablesModel)
        {
            ReturnSQL ReturnSQL = new ReturnSQL();
            string OrderBy = SQLFunctions.OrderByDataTable(DatatablesModel);
            string Where = SQLFunctions.WhereByDataTable(DatatablesModel);
            string Paginacao = SQLFunctions.SetPaginacao(DatatablesModel.start, DatatablesModel.length);

            ReturnSQL.SQL = _sqlContainer.RelatorioLoja()
                .Replace("{COLUMNS}", _sqlContainer.RelatorioLojaColunas())
                .Replace("{WHERE}", Where)
                .Replace("{ORDERBY}", OrderBy)
                .Replace("{PAGINAR}", Paginacao);

            return ReturnSQL;
        }

        public ReturnSQL GetRelatorioLojaCount(bool Filtrar = false, DatatablesModelDTO DatatablesModel = null)
        {
            ReturnSQL ReturnSQL = new ReturnSQL();
            string Where = string.Empty;

            if(Filtrar)
            {
                Where = SQLFunctions.WhereByDataTable(DatatablesModel);
            }

            ReturnSQL.SQL = _sqlContainer.RelatorioLoja()
                .Replace("{COLUMNS}", _sqlContainer.RelatorioLojaCount())
                .Replace("{WHERE}", Where)
                .Replace("{ORDERBY}", string.Empty)
                .Replace("{PAGINAR}", string.Empty);

            return ReturnSQL;
        }
    }
}
