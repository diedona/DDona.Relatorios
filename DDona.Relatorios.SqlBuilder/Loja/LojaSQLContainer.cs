using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.SqlBuilder.Loja
{
    public class LojaSQLContainer
    {
        public string RelatorioLoja()
        {
            return @"
                SELECT		{COLUMNS}
                FROM		LOJA L       
                {WHERE}         
                {ORDERBY}
                {PAGINAR}
            ";
        }

        public string RelatorioLojaColunas()
        {
            return @"
                    L.Codigo,
			        L.Nome,
			        L.Nota,
			        L.Investimento
            ";
        }

        public string RelatorioLojaCount()
        {
            return @"
                    COUNT(L.Codigo)
            ";
        }
    }
}
