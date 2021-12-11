using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vestel_Demo_CRM.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        
        [AllowAnonymous]
        public IActionResult Index()
        {
            var value = pm.TGetListWithCategory();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> categoryValues = (from x in cm.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}