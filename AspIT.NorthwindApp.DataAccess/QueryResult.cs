using System.Data;

namespace AspIT.NorthwindApp.DataAccess
{
    public class QueryResult
    {
        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        /// <param name="dataSet">The dataset of the result</param>
        /// <param name="rowsAffected">The amount of affected rows</param>
        public QueryResult(DataSet dataSet, int rowsAffected)
        {
            DataSet = dataSet;
            RowsAffected = rowsAffected;
        }

        public DataSet DataSet { get; }
        public int RowsAffected { get; }
    }
}
