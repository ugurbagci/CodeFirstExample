using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgursNorthwind.DAL.ORM.Interface;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class Product : BaseEntity, IProduct
    {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short QuantityInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } 

        public virtual List<OrderDetail>OrderDetails { get; set; }
    }
}
