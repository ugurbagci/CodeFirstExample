﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgursNorthwind.DAL.ORM.Enum;

namespace UgursNorthwind.DAL.ORM.Interface
{
    public interface IBaseEntity
    {
        int ID { get; set;}
        DateTime UppdateDate { get; set; }
        DateTime AddDate { get; set; }
        DateTime DeleteDate { get; set; }

        Status Status { get; set; }
    }
}
