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
        protected DataRepository()
        {

        }

        public abstract List<TEntity> GetAll();

        public abstract TEntity GetById(int id);
    }
}
