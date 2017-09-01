using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.NorthwindApp.Entities
{
    public class Customer : Person
    {
        public Customer(string firstName, string lastName, DateTime birthDate, string address, string city, string region, string postalCode, string country, ContactInfo contactInfo) : base(firstName, lastName, birthDate, address, city, region, postalCode, country, contactInfo)
        {

        }
    }
}
