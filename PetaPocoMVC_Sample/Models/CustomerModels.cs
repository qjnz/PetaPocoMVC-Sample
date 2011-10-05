using System.Collections.Generic;
using NorthwindConnection;

namespace PetaPocoMVC_Sample.Models
{
    public class CustomerModel
    {
        public IEnumerable<Customer> GetCustomers()
        {
            var db = new PetaPoco.Database("NorthwindConnection");
            return db.Query<Customer>("SELECT * FROM Customers");
        }
    }
}