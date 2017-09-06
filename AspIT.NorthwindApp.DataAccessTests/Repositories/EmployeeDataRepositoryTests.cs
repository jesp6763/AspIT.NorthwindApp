using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspIT.NorthwindApp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.NorthwindApp.DataAccess.Repositories.Tests
{
    [TestClass]
    public class EmployeeDataRepositoryTests
    {
        [TestMethod]
        public void SaveTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        /// <summary>
        /// Tests to see if an employee returns successfully with id
        /// </summary>
        [TestMethod]
        public void GetByIdSuccess()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.GetById(1);
        }

        /// <summary>
        /// Tests to see if it gives the correct exception if a invalid id is given
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetByIdFail1()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.GetById(0);
        }

        /// <summary>
        /// Tests to see if it gives the correct exception if the given id is less than 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetByIdFail2()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.GetById(-1);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}