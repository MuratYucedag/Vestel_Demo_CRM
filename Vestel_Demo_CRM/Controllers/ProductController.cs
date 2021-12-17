using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Vestel_Demo_CRM.Models;
using X.PagedList;

namespace Vestel_Demo_CRM.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public IActionResult Index(int page = 1)
        {
            //123 456 789
            var value = pm.TGetListWithCategory().ToPagedList(page, 2);
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
        [HttpGet]
        public IActionResult AddProductWithImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProductWithImage(AddProductImage p)
        {
            Product product = new Product();

            if (p.ProductImage != null)
            {
                var extension = Path.GetExtension(p.ProductImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ProductImages/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.ProductImage.CopyTo(stream);
                product.ImageURL = newimagename;
            }
            product.CategoryID = 2;
            product.Name = p.Name;
            product.Price = p.Price;
            product.Status = true;
            product.Stock = p.Stock;
            product.Description = p.Description;
            pm.TAdd(product);
            return RedirectToAction("Index");
        }
    }
}