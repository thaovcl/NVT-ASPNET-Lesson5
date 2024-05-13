using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NVT.Lesson04.Models;

namespace NVT.Lesson04.Controllers
{
    public class NvtCustomerController : Controller
    {
        // GET: NvtCustomer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NvtCustomerDetail()
        {
            var customer = new NvtCustomer()
            {
                CustomerId = 1,
                Firtname = "Nguyen Van",
                Lastname = "Thao",
                Address = "K22CNT1",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;

            return View();
        }
        // Get: NvtListCustomer
        public ActionResult NvtListCustomer()
        {
            var list = new List<NvtCustomer>()
            {
                new NvtCustomer(){
                CustomerId = 1,
                Firtname = "Nguyen Van",
                Lastname = "Thao",
                Address = "K22CNT1",
                YearOfBirth = 2004
                },
                new NvtCustomer(){
                CustomerId = 2,
                Firtname = "Le Vinh",
                Lastname = "Huy",
                Address = "K22CNT1",
                YearOfBirth = 2004
                },
                new NvtCustomer(){
                CustomerId = 3,
                Firtname = "Do Trong",
                Lastname = "Huy",
                Address = "K22CNT1",
                YearOfBirth = 2004
                },
                new NvtCustomer(){
                CustomerId = 1,
                Firtname = "Đàm Vĩnh",
                Lastname = "Tuy",
                Address = "K22CNT1",
                YearOfBirth = 2004
                }
            };
            //ViewBag.list = list; //Đưa dữ liệu ra view bằng đối tượng viewBag

            return View(list);
        }
    }
}