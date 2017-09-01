using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess.Repositories
{
    public class EmployeeDataRepository : DataRepository<Employee>
    {
        /// <summary>
        /// Finds all employees from database
        /// </summary>
        /// <returns>All employees from database</returns>
        public override IEnumerable<Employee> GetAll()
        {
            List<Employee> employeeList = new List<Employee>();
            DataSet employees = queryExecutor.Execute($"SELECT * FROM {tableName}");

            if (employees.Tables["Table"] != null)
            {
                foreach (DataRow row in employees.Tables["Table"].Rows)
                {
                    Employee employee = new Employee(row.Field<string>("TitleOfCourtesy"), row.Field<string>("Title"),
                        row.Field<DateTime>("HireDate"), row.Field<string>("Extension"), row.Field<string>("Notes"),
                        row.Field<int?>("ReportsTo"), row.Field<string>("FirstName"), row.Field<string>("LastName"),
                        row.Field<DateTime>("BirthDate"), row.Field<string>("Address"), row.Field<string>("City"),
                        row.Field<string>("Region"), row.Field<string>("PostalCode"), row.Field<string>("Country"),
                        new ContactInfo(row.Field<string>("HomePhone")));
                    employeeList.Add(employee);
                }
            }

            return employeeList;
        }

        public override void Save(Employee employee)
        {
            string dbNull = "NULL";
            queryExecutor.Execute($"INSERT INTO {tableName} (LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath) VALUES('{employee.LastName}', '{employee.FirstName}', '{employee.Title}', '{employee.TitleOfCourtesy}', '{employee.BirthDate.Year}{employee.BirthDate.Month}{employee.BirthDate.Day}', '{employee.HireDate.Year}{employee.HireDate.Month}{employee.HireDate.Day}', '{employee.Address}', '{employee.City}', '{employee.Region}', '{employee.PostalCode}', '{employee.Country}', '{employee.ContactInfo.HomePhone}', '{employee.Extension}', NULL, 'No notes', {employee.ReportsTo?.ToString() ?? dbNull}, '{employee.PhotoPath}')");
        }

        public override void Update()
        {
            queryExecutor.Execute("");
        }

        public override void Delete()
        {
            
        }
    }
}
