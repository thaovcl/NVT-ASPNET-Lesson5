using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baitap1.Models;

namespace Baitap1.Controllers
{
    public class NVTProductController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NVTProductList()
        {

            var list = new List<Product>()
            {
                new Product(){
                ProductId="P001",
                ProductName="Lẩu vịt",
                Unit="Nồi",
                Price= 150000
                },
                new Product(){
                ProductId="P002",
                ProductName="Lẩu cá kèo",
                Unit="Nồi",
                Price= 250000
                },
                new Product(){
                ProductId="P003",
                ProductName="Lẩu thập cẩm",
                Unit="Nồi",
                Price= 350000
                },
            };
            return View(list);
        }

    }
}