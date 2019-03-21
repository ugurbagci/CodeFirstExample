using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgursNorthwind.DAL.ORM.Enum;
using UgursNorthwind.DAL.ORM.Interface;

namespace UgursNorthwind.DAL.ORM.Entity
{
    public class BaseEntity : IBaseEntity
    {
        public int ID { get; set; }

        private DateTime _uppdateDate = DateTime.Now;
        public DateTime UppdateDate { get { return _uppdateDate; } set { _uppdateDate = value; } }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }


        private DateTime _deleteDate = DateTime.Now;
        public DateTime DeleteDate { get { return _deleteDate; } set { _deleteDate = value; } }

        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }


    }
}
