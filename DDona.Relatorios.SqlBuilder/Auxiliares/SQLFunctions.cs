using DDona.Relatorios.DTO.DataTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.SqlBuilder.Auxiliares
{
    public static class SQLFunctions
    {
        public static string SetPaginacao(int skip, int QtdItens)
        {
            return string.Format(" OFFSET ({0}) ROWS FETCH NEXT ({1}) ROWS ONLY ", 
                skip.ToString(), QtdItens.ToString());
        }

        public static string OrderByDataTable(DatatablesModelDTO DatatablesModel)
        {
            StringBuilder sbOrderBy = new StringBuilder();
            foreach (var Order in DatatablesModel.order)
            {
                sbOrderBy.AppendFormat(" {0} {1} ", DatatablesModel.columns[Order.column].name, Order.dir);

                if(DatatablesModel.order.IndexOf(Order) < (DatatablesModel.order.Count - 1))
                {
                    sbOrderBy.Append(", ");
                }
            }

            if(sbOrderBy.Length > 0)
            {
                sbOrderBy.Insert(0, " ORDER BY ");
            }

            return sbOrderBy.ToString();
        }

        public static string WhereByDataTable(DatatablesModelDTO DatatablesModel)
        {
            if(string.IsNullOrWhiteSpace(DatatablesModel.search.value))
            {
                return string.Empty;
            }
            else
            {
                StringBuilder sbWhere = new StringBuilder();
                string Valor = DatatablesModel.search.value;
                foreach (var Column in DatatablesModel.columns)
                {
                    
                }

                return sbWhere.ToString();
            }
        }
    }
}
