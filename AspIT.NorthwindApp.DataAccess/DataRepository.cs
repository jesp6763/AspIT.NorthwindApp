using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess
{
    public class DataRepository<TEntity> where TEntity : IPersistable
    {
        private string tableName;

        public DataRepository(string tableName)
        {
            this.tableName = tableName;
        }

        public List<TEntity> GetAll()
        {
            List<Employee> employeeList = new List<Employee>();
            QueryExecutor queryExecutor = new QueryExecutor("Name=Northwind");
            DataSet employees = queryExecutor.Execute($"SELECT * FROM ´{tableName}´");

            foreach(DataRow row in employees.Tables[tableName].Rows)
            {
                Employee employee = new Employee(row.Field<string>("TitleOfCourtesy"), row.Field<string>("Title"), row.Field<DateTime>("HireDate"), row.Field<string>("Extension"), row.Field<string>("Notes"), row.Field<int>("ReportsTo"), row.Field<string>("FirstName"), row.Field<string>("LastName"), row.Field<DateTime>("BirthDate"), row.Field<string>("Address"), row.Field<string>("City"), row.Field<string>("Region"), row.Field<string>("PostalCode"), row.Field<string>("Country"), new ContactInfo(row.Field<string>("HomePhone")));
                employeeList.Add(employee);
            }

            return employeeList;
        }

        public TEntity GetById(int id)
        {
            
        }
    }
}
