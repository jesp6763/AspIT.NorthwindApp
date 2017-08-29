using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess
{
    public class DataRepository<TEntity> where TEntity : IPersistable
    {
        private string tableName;

        public DataRepository(string tableName)
        {
            this.tableName = tableName;
        }

        public List<TEntity> GetAll()
        {
            QueryExecutor queryExecuter = new QueryExecutor("Name=Northwind");
            DataTable data = queryExecuter.Execute($"SELECT * FROM ´{tableName}´");
            return new List<TEntity>();
        }
    }
}
