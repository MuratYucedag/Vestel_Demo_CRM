using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Employee { get; set; }
        public string Code { get; set; }
        public bool Status { get; set; }
    }
}
