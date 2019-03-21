using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgursNorthwind.DAL.ORM.Interface
{
    public interface IProduct
    {
        // mapped işlemi yapılacak
        string ProductName { get; set; }

        // mapped işlemi yapılacak
        string QuantityPerUnit { get; set; }
        decimal UnitPrice { get; set; }
        short QuantityInStock { get; set; }
        short UnitsOnOrder { get; set; }
        short ReorderLevel { get; set; }
        bool Discontinued { get; set; }

    }
}
