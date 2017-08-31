﻿using System;
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

        public override List<Employee> GetAll()
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

        public override Employee GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
