using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Request
    {
        public int RequestID { get; set; }
        public int RequestPerson { get; set; }
        public string RequestType { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
    }
}
