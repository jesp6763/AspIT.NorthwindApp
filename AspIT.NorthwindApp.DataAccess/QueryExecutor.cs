using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.NorthwindApp.DataAccess
{
    public class QueryExecutor
    {
        private string connectionString;

        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        /// <param name="connectionString">The connection string</param>
        public QueryExecutor(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Executes a sql query
        /// </summary>
        /// <param name="sqlQuery">The sql query to execute</param>
        /// <returns>A dataset as a result from the sql query</returns>
        public DataSet Execute(string sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            return null;
        }
    }
}
