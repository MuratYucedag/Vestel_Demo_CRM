using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vestel_Demo_CRM.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustomerPanelController : Controller
    {
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.value = usermail;

            Context c = new Context();
            var username = c.Customers.Where(x => x.Mail == usermail).Select(y => y.Name).FirstOrDefault();
            ViewBag.value2 = username;
            return View();
        }
    }
}
