using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.DataAccess
{
    public class ReturnSQL
    {
        public string SQL { get; set; }
        public List<GenericSQLParameter> Parameters { get; set; }

        public ReturnSQL()
        {
            Parameters = new List<GenericSQLParameter>();
        }
    }
}
