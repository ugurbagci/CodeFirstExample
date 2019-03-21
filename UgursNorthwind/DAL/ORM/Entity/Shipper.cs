﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class Shipper:BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual List<Order>Orders { get; set; }
    }
}
