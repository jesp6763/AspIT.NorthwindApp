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
            queryExecutor = new QueryExecutor(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Northwind");
        }

        public abstract IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Finds an entity with id
        /// </summary>
        /// <param name="id">The id of the entity</param>
        /// <returns>An entity if it exists</returns>
        /// <exception cref="NullReferenceException">Thrown when no entity were found with the specified id</exception>
        public virtual TEntity GetById(int id)
        {
            IEnumerable<TEntity> entities = GetAll();
            foreach (TEntity entity in entities)
            {
                if (entity.Id == id)
                {
                    return entity;
                }
            }

            throw new NullReferenceException("No entity with that id exists");
        }

        public abstract void Save();

        public abstract void Update();
    }
}
