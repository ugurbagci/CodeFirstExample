using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class Region:BaseEntity
    {
        public string RegionDescription { get; set; }

        public virtual List<Territory>Territories { get; set; }
    }
}
