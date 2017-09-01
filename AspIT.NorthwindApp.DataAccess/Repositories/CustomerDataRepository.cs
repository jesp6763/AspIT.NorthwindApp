using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess.Repositories
{
    public class CustomerDataRepository : DataRepository<Customer>
    {
        public override void Delete()
        {
            
        }

        public override IEnumerable<Customer> GetAll()
        {
            throw new Exception();
        }

        public override void Save(Customer entity)
        {
            
        }

        public override void Update()
        {
            
        }

        public void SayHi()
        {
            Debug.WriteLine($"Table name {tableName}");
        }
    }
}
