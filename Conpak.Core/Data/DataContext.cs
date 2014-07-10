using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Conpak.Core.Data
{
    public class DataContext: IDisposable
    {
        private IDbConnection _connection;

        public DataContext()
        {
            
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conpak.Data"].ConnectionString);
            
        }

        public DataContext(String connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public IEnumerable<T> Query<T>(string sql, dynamic parameters)
        {
            var dynamicParameters = new DynamicParameters(parameters);
            return _connection.Query<T>(sql, dynamicParameters);
        }

        public T Get<T>(Guid id)
        {
            var tableName = typeof (T).Name;
            var sql = String.Format("select * from {0} where Id = @Id", tableName);

            return _connection.Query<T>(sql, new {Id = id}).FirstOrDefault();
        }

        public void Dispose()
        {
            //Cleanup connection stuff
        }
    }
}
