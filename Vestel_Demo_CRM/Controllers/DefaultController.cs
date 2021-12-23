using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vestel_Demo_CRM.Models;

namespace Vestel_Demo_CRM.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListCustomer()
        {
            var jsoncustomer = JsonConvert.SerializeObject(customers);
            return Json(jsoncustomer);
        }

        public IActionResult GetByID(int musteriid)
        {
            var findcustomer = customers.FirstOrDefault(x => x.ID == musteriid);
            var jsoncustomer = JsonConvert.SerializeObject(findcustomer);
            return Json(jsoncustomer);
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerClass p)
        {
            customers.Add(p);
            var jsoncustomer = JsonConvert.SerializeObject(p);
            return Json(jsoncustomer);
        }

        private static List<CustomerClass> customers = new List<CustomerClass>()
        {
            new CustomerClass
            {
                ID=1,
                CustomerName="Ali"
            },
             new CustomerClass
            {
                ID=2,
                CustomerName="Ayşe"
            },
              new CustomerClass
            {
                ID=3,
                CustomerName="Mehmet"
            },
        };
    }
}
