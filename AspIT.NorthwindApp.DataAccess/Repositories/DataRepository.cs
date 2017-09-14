using System;
using System.Collections.Generic;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess.Repositories
{
    /// <summary>
    /// Represents a data repository
    /// </summary>
    /// <typeparam name="TEntity">The data repository type</typeparam>
    public abstract class DataRepository<TEntity> where TEntity : IPersistable
    {
        protected QueryExecutor queryExecutor;
        protected static readonly string tableName;
        protected const string DBNull = "NULL";
        
        /// <summary>
        /// Initializes a new instance of this class
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when can't open a connection without specifying a data source or server. or the connection is already open.</exception>
        /// <exception cref="SqlException">Thrown when a connection-level error occurred while opening the connection.</exception>
        protected DataRepository()
        {
            queryExecutor = new QueryExecutor(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind");
            //queryExecutor = new QueryExecutor(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Northwind"); // Test db
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
        /// <exception cref="ArgumentOutOfRangeException">Thrown when id is less than 0</exception>
        public virtual TEntity GetById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

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
        /// <exception cref="ArgumentOutOfRangeException">Thrown when id is less than 0</exception>
        /// <exception cref="ArgumentException">Thrown when no entity is found with the specified id</exception>
        public virtual void Delete(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            string entityName = typeof(TEntity).Name;
            QueryResult result = queryExecutor.Execute($"DELETE FROM {tableName} WHERE {entityName}ID={id}");

            if (result.RowsAffected  <= 0)
            {
                throw new ArgumentException($"No rows were deleted. {entityName} with that id not found");
            }
        }
    }
}
