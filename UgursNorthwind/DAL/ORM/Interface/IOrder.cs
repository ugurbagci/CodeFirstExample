using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgursNorthwind.DAL.ORM.Interface
{
    public interface IOrder
    { 
        DateTime? OrderDate { get; set; }
        DateTime? RequiredDate { get; set; }
        DateTime? ShippedDate { get; set; }

        decimal? Freight { get; set; }
       // [MaxLength(50)] -- framework yüklenecek 
        string ShipName { get; set; }
        string ShipAddress { get; set; }
        string ShipCity { get; set; }
        string ShipRegion { get; set; }
        string ShipPostalCode { get; set; }
        string ShipCountry { get; set; }


    }
}
