using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess.Repositories
{
    public class EmployeeDataRepository : DataRepository<Employee>
    {
        public const string TableName = "dbo.Employees";

        /// <summary>
        /// Finds all employees from database
        /// </summary>
        /// <returns>All employees from database</returns>
        public override IEnumerable<Employee> GetAll()
        {
            List<Employee> employeeList = new List<Employee>();
            QueryExecutor queryExecutor = new QueryExecutor("Name=Northwind");
            DataSet employees = queryExecutor.Execute($"SELECT * FROM ´{TableName}´");

            foreach (DataRow row in employees.Tables[TableName].Rows)
            {
                Employee employee = new Employee(row.Field<string>("TitleOfCourtesy"), row.Field<string>("Title"), row.Field<DateTime>("HireDate"), row.Field<string>("Extension"), row.Field<string>("Notes"), row.Field<int>("ReportsTo"), row.Field<string>("FirstName"), row.Field<string>("LastName"), row.Field<DateTime>("BirthDate"), row.Field<string>("Address"), row.Field<string>("City"), row.Field<string>("Region"), row.Field<string>("PostalCode"), row.Field<string>("Country"), new ContactInfo(row.Field<string>("HomePhone")));
                employeeList.Add(employee);
            }

            return employeeList;
        }

        /// <summary>
        /// Finds an employee with id
        /// </summary>
        /// <param name="id">The id of the employee</param>
        /// <returns>An employee if an employee exists with specified id</returns>
        /// <exception cref="NullReferenceException">Thrown when no employees were found with the specified id</exception>
        public override Employee GetById(int id)
        {
            IEnumerable<Employee> employees = GetAll();
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    return employee;
                }
            }

            throw new NullReferenceException("No employee with that id exists");
        }
    }
}
