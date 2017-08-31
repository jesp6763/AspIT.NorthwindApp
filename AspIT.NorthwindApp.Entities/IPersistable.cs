using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.NorthwindApp.Entities
{
    public interface IPersistable
    {
        /// <summary>
        /// Gets or sets an id
        /// </summary>
        int Id { get; set; }
    }
}
