using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Vestel_Demo_CRM.Models;

namespace Vestel_Demo_CRM.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class FileController : Controller
    {
        public IActionResult ExportExcelCustomerList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Müşteri Listesi");
                worksheet.Cell(1, 1).Value = "Müşteri ID";
                worksheet.Cell(1, 2).Value = "Müşteri Adı";

                int RowCount = 2;
                foreach (var item in GetCustomerList())
                {
                    worksheet.Cell(RowCount, 1).Value = item.ID;
                    worksheet.Cell(RowCount, 2).Value = item.CustomerName;
                    RowCount++;
                }

                using(var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }

            }
        }

        public List<CustomerClass> GetCustomerList()
        {
            List<CustomerClass> cc = new List<CustomerClass>()
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
                    CustomerName="Oya"
                }
            };
            return cc;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
