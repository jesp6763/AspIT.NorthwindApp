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
        public List<TEntity> GetAll()
        {
            QueryExecutor queryExecuter = new QueryExecutor("Name=Northwind");
            DataTable data = queryExecuter.Execute($"SELECT * FROM ´dbo.{typeof(TEntity).Name}´");
            return new List<TEntity>();
        }
    }
}
