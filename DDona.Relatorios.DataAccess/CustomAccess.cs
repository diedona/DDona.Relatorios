using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.DataAccess
{
    public class CustomAccess
    {
        public List<T> Get<T>(ReturnSQL ReturnSQL)
        {
            DapperWrapper Dapper = new DapperWrapper();
            return Dapper.Get<T>(ReturnSQL.SQL, ConvertToDapperParameters(ReturnSQL.Parameters));
        }

        private DynamicParameters ConvertToDapperParameters(List<GenericSQLParameter> Parameters)
        {
            DynamicParameters DynamicParameters = new DynamicParameters();

            foreach (var Parameter in Parameters)
            {
                DynamicParameters.Add(Parameter.Name, Parameter.Value, Parameter.DbType);
            }

            return DynamicParameters;
        }
    }
}
