using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vestel_Demo_CRM.Models;

namespace Vestel_Demo_CRM.Controllers
{
    [AllowAnonymous]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryvalue = 10,
                categoryname = "Teknoloji"
            });
            list.Add(new CategoryClass
            {
                categoryvalue = 20,
                categoryname = "Yazılım"
            });
            list.Add(new CategoryClass
            {
                categoryvalue = 30,
                categoryname = "Spor"
            });
            return Json(new { JSONList = list });
        }
        public JsonResult ProductChart()
        {
            List<ProductClass> list = new List<ProductClass>();
            Context c = new Context();
            list = c.Products.Select(x => new ProductClass
            {
                productame = x.Name,
                productstock = x.Stock
            }).ToList();
            return Json(new { JSONList = list });
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
