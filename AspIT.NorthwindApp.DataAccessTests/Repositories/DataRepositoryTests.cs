using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspIT.NorthwindApp.DataAccess.Repositories;
using System;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess.Repositories.Tests
{
    [TestClass]
    public class DataRepositoryTests
    {
        [TestMethod]
        public void ConstructorSuccess()
        {
            QueryExecutor queryExecutor = new QueryExecutor(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorFail1()
        {
            QueryExecutor queryExecutor = new QueryExecutor(@"dss");
        }

        /// <summary>
        /// Tests to see if it throws an InvalidOperationException if the connection string has not specified any data source or server
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ConstructorFail2()
        {
            QueryExecutor queryExecutor = new QueryExecutor("");
        }
    }
}