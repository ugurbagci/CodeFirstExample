using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgursNorthwind.DAL.ORM.Interface
{
    public interface ICompanyInfo
    {
        string CompanyName { get; set; }      
        string ContactName { get; set; }
        string ContactTitle { get; set; }
    }
}
