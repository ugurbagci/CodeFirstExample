using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgursNorthwind.DAL.ORM.Interface;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class Customer:BaseEntity,IInfo,ICompanyInfo
    {
        // ICompanInfo interface den aldım...
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        // IInfo interface den aldım...
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }


        public virtual List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
        public virtual List<Order>Orders { get; set; }
    }
}
