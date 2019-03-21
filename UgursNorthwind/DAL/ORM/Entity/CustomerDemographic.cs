using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class CustomerDemographic:BaseEntity
    {
        public string CustomerDesc { get; set; }
        public virtual List<CustomerCustomerDemo>CustomerCustomerDemos { get; set; }
    }
}
