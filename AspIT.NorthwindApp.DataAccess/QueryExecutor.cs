using System;
using System.Data;
using System.Data.SqlClient;

namespace AspIT.NorthwindApp.DataAccess
{
    public class QueryExecutor
    {
        /// <summary>
        /// The connection string to the database
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        /// <param name="connectionString">The connection string</param>
        public QueryExecutor(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Gets or sets the connection string
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when can't open a connection without specifying a data source or server. or the connection is already open.</exception>
        /// <exception cref="SqlException">Thrown when a connection-level error occurred while opening the connection.</exception>
        public string ConnectionString
        {
            get => connectionString;
            private set
            {
                // Test connection string
                using (SqlConnection conn = new SqlConnection(value))
                {
                    conn.Open();
                }

                connectionString = value;
            }
        }

        /// <summary>
        /// Executes a sql query
        /// </summary>
        /// <param name="sqlQuery">The sql query to execute</param>
        /// <returns>A dataset as a result from the sql query, and how many rows were affected</returns>
        /// <exception cref="InvalidOperationException">Thrown when can't open a connection without specifying a data source or server. or the connection is already open.</exception>
        /// <exception cref="SqlException">Thrown when a connection-level error occurred while opening the connection.</exception>
        public DataSet Execute(string sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlQuery, connection))
                {
                    DataSet dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }
    }
}
