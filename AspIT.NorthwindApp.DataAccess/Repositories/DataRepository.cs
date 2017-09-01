using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspIT.NorthwindApp.Entities;
using System.Diagnostics;

namespace AspIT.NorthwindApp.DataAccess.Repositories
{
    public abstract class DataRepository<TEntity> where TEntity : IPersistable
    {
        protected QueryExecutor queryExecutor;
        protected static string tableName;

        protected DataRepository()
        {
            queryExecutor = new QueryExecutor(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind");
        }

        static DataRepository()
        {
            tableName = $"dbo.{typeof(TEntity).Name}s";
        }

        /// <summary>
        /// Finds all entities from database
        /// </summary>
        /// <returns>All entities from database</returns>
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

        /// <summary>
        /// Saves a entity into the database
        /// </summary>
        /// <param name="entity">The entity to save</param>
        public abstract void Save(TEntity entity);

        /// <summary>
        /// Updates a entity
        /// </summary>
        public abstract void Update(int id, TEntity entity);

        /// <summary>
        /// Deletes a entity
        /// </summary>
        public virtual void Delete(int id)
        {
            queryExecutor.Execute($"DELETE FROM {tableName} WHERE {typeof(TEntity).Name}ID={id}");
        }
    }
}
