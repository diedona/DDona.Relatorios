using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Relatorios.DataAccess
{
    public class GenericSQLParameter
    {
        public object Value { get; private set; }
        public string Name { get; private set; }
        public DbType DbType { get; private set; }

        public GenericSQLParameter(string name, object value, DbType dbType)
        {
            this.Value = value;
            this.Name = name;
            this.DbType = dbType;
        }
    }
}
