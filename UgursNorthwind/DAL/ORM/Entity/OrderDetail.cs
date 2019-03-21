using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class OrderDetail:BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        // bağlantılarımı yapıyorum 2 farklı tablo ile - bunlar Order ve Product
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }



    }
}
