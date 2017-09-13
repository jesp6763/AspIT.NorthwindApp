using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspIT.NorthwindApp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess.Repositories.Tests
{
    [TestClass]
    public class EmployeeDataRepositoryTests
    {
        [TestMethod]
        public void SaveSuccess()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            Employee employee = new Employee("Mr.", "Nugget Representive", new DateTime(1999, 10, 3), "9999", "Best nugget representive ever", null, "Pierce", "Pan", new DateTime(1959, 3, 10), "Norly 22", "Undercity", "Basement", "999", "Crypt", new ContactInfo("99999999"));
            repository.Save(employee);

            IEnumerable<Employee> employees = repository.GetAll();
            Assert.AreEqual(employee.FirstName, employees.Last().FirstName);
        }

        [TestMethod]
        public void UpdateSuccess()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            Employee employee = new Employee("Mr.", "Vice President, Sales", new DateTime(1992, 8, 14), "3457", "Andreww ee notes", null, "Andrew", "Fuller", new DateTime(1952, 2, 19), "908 W. Capital Way", "Tacoma", "WA", "98401", "USA", new ContactInfo("(206) 555-9482"));
            repository.Update(2, employee);

            Employee updatedEmployee = repository.GetById(2);
            Assert.AreEqual(employee.TitleOfCourtesy, updatedEmployee.TitleOfCourtesy);
        }

        /// <summary>
        /// Tests to see if an employee returns successfully with a correct id
        /// </summary>
        [TestMethod]
        public void GetByIdSuccess()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.GetById(2);
        }

        /// <summary>
        /// Tests to see if it gives a NullReferenceException if an employee with the given id does not exist
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetByIdFail1()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.GetById(0);
        }

        /// <summary>
        /// Tests to see if it gives a ArgumentOutOfRangeException if the given id is less than 0
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetByIdFail2()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.GetById(-1);
        }

        [TestMethod]
        public void DeleteSuccess()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.Delete(2017);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DeleteFail1()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.Delete(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteFail2()
        {
            EmployeeDataRepository repository = new EmployeeDataRepository();
            repository.Delete(66);
        }
    }
}