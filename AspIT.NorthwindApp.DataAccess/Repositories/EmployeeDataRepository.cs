using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
                        new ContactInfo(row.Field<string>("HomePhone")))
                        { Id = row.Field<int>("EmployeeID") };
                    employeeList.Add(employee);
                }
            }

            return employeeList;
        }

        public override void Save(Employee employee)
        {
            queryExecutor.Execute($"INSERT INTO {tableName} (LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath) VALUES('{employee.LastName}', '{employee.FirstName}', '{employee.Title}', '{employee.TitleOfCourtesy}', '{employee.BirthDate.Year}{employee.BirthDate.Month}{employee.BirthDate.Day}', '{employee.HireDate.Year}{employee.HireDate.Month}{employee.HireDate.Day}', '{employee.Address}', '{employee.City}', '{(employee.Region == string.Empty ? DBNull : employee.Region)}', '{employee.PostalCode}', '{employee.Country}', '{employee.ContactInfo.HomePhone}', '{employee.Extension}', NULL, 'No notes', {employee.ReportsTo?.ToString() ?? DBNull}, '{employee.PhotoPath}')");
        }

        public override void Update(int id, Employee employee)
        {
            queryExecutor.Execute($"UPDATE {tableName} SET LastName='{employee.LastName}', FirstName='{employee.FirstName}', Title='{employee.Title}', TitleOfCourtesy='{employee.TitleOfCourtesy}', BirthDate='{employee.BirthDate.Year}{employee.BirthDate.Month}{employee.BirthDate.Day}', HireDate='{employee.HireDate.Year}{employee.HireDate.Month}{employee.HireDate.Day}', Address='{employee.Address}', City='{employee.City}', Region='{(employee.Region == string.Empty ? DBNull : employee.Region)}', PostalCode='{employee.PostalCode}', Country='{employee.Country}', HomePhone='{employee.ContactInfo.HomePhone}', Extension='{employee.Extension}', Notes='{employee.Notes}', ReportsTo={employee.ReportsTo?.ToString() ?? DBNull}, PhotoPath='{employee.PhotoPath}' WHERE EmployeeID={employee.Id}");
        }
    }
}
