using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vestel_Demo_CRM.ViewComponents.Category
{
    public class GetListCategory : ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}
