using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspIT.NorthwindApp.Entities;

namespace AspIT.NorthwindApp.DataAccess
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Get(int id);
    }
}
