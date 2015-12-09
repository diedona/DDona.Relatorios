using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DDona.Relatorios.DataAccess
{
    public class DapperWrapper
    {
        private const string ConnectionName = "RelatoriosContext";
        private string ConnectionString = string.Empty;

        public DapperWrapper()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }
        
        public List<T> Get<T>(string SQL, DynamicParameters Parameters)
        {
            using(IDbConnection _db = new SqlConnection(ConnectionString))
            {
                return _db.Query<T>(SQL, Parameters).ToList();
            }
        }
    }
}
