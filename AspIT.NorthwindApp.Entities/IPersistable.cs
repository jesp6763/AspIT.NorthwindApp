using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.NorthwindApp.Entities
{
    public interface IPersistable
    {
        int Id { get; set; }
    }
}
