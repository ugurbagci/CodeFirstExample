using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class Territory:BaseEntity
    {
        public string TerritoryDescription { get; set; }

        public int RegionID { get; set; }
        public virtual Region Region { get; set; }

        public virtual List<EmployeeTerritory>EmployeeTerritories { get; set; }
    }
}
