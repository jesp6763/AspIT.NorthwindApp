using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.NorthwindApp.DataAccess
{
    public class QueryExecutor
    {
        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        /// <param name="connectionString">The connection string</param>
        public QueryExecutor(string connectionString)
        {
            
        }

        /// <summary>
        /// Executes a sql query
        /// </summary>
        /// <param name="sqlQuery">The sql query to execute</param>
        /// <returns>A dataset as a result from the sql query</returns>
        public DataSet Execute(string sqlQuery)
        {
            return null;
        }
    }
}
