using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgursNorthwind.DAL.ORM.Interface;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class Order:BaseEntity,IOrder
    {



        

        // IOrder interface den alıyorum, aldım...
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        // fk için...
        public virtual List<OrderDetail> OrderDetails { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        public int ShipperID { get; set; }
        public virtual Shipper Shipper { get; set; }

    }
}
