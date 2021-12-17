using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vestel_Demo_CRM.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class StatisticController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var value1 = c.Categories.Count();
            var value2 = c.Categories.Where(x => x.Status == true).Count();
            var value3 = c.Categories.Where(x => x.Status == false).Count();

            ViewBag.v1 = value1;
            ViewBag.v2 = value2;
            ViewBag.v3 = value3;
            return View();
        }
    }
}
