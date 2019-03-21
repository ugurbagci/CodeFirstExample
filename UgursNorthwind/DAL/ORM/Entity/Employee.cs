using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgursNorthwind.DAL.ORM.Interface;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class Employee:BaseEntity,IInfo
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        // IInfo interface den alıyorum...
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        // kalan diğer özelliklerim...
        public string Extension { get; set; }
        public string Notes { get; set; }
        public string PhotoPath { get; set; }

        //image değişken türü öğrenilip eklenecek..!
        // public ? Photo { get; set; }

        public virtual List<EmployeeTerritory>EmployeeTerritories { get; set; }

        public virtual List<Order>Orders { get; set; }


    }
}
