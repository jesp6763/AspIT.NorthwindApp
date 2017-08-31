using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess.Repositories
{
    public abstract class DataRepository<TEntity> where TEntity : IPersistable
    {
        protected QueryExecutor queryExecutor;

        protected DataRepository()
        {
            queryExecutor = new QueryExecutor("Data Source=ProjectsV13;Initial Catalog=Northwind");
        }

        public abstract IEnumerable<TEntity> GetAll();

        public abstract TEntity GetById(int id);
    }
}
