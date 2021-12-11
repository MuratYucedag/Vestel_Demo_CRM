using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vestel_Demo_CRM.Areas.Calls.Controllers
{
    [Area("Calls")]
    public class RequestController : Controller
    {
        RequestManager requestManager = new RequestManager(new EfRequestDal());
        public IActionResult Index()
        {
            var values = requestManager.TGetList();
            return View(values);
        }
    }
}
