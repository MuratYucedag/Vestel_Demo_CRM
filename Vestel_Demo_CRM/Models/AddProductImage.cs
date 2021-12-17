using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vestel_Demo_CRM.Models
{
    public class AddProductImage
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public IFormFile ProductImage { get; set; }
        public bool Status { get; set; }
        public int CategoryID { get; set; }
    }
}
