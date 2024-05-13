using NVT.Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVT.Lesson05.Controllers
{
    public class NvtCustomerScaffdingController : Controller
    {
        //mockdata
        private static List<NvtCustomer> listCustomer = new List<NvtCustomer>()
            {
                new NvtCustomer()
            {
                    CustomerId = 1,
                    Firtname = "Nguyen Van",
                    Lastname = "Thao",
                    Address = "K22CNT1",
                    YearOfBirth = 2004
                    },
                new NvtCustomer()
            {
                    CustomerId = 2,
                    Firtname = "Le Vinh",
                    Lastname = "Huy",
                    Address = "K22CNT1",
                    YearOfBirth = 2004
                    },
                new NvtCustomer()
            {
                    CustomerId = 3,
                    Firtname = "Do Trong",
                    Lastname = "Huy",
                    Address = "K22CNT1",
                    YearOfBirth = 2004
                    },
                new NvtCustomer()
            {
                    CustomerId = 1,
                    Firtname = "Đàm Vĩnh",
                    Lastname = "Tuy",
                    Address = "K22CNT1",
                    YearOfBirth = 2004
                    }
    };
    // GET: NvtCustomerScaffding
    //listCutomer
        public ActionResult Index()
            {
                return View(listCustomer);
            }
        [HttpGet]
        public ActionResult NvtCreate()
        {
            var model = new NvtCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NvtCreate(NvtCustomer model)
        {
            //Thêm mới đối tượng khách hàng vào danh sách dữ liệu
            listCustomer.Add(model);

            //return View(model);
            //chuyển về trang danh sách
            return RedirectToAction("Index");
        }
        public ActionResult NvtEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x => x.CustomerId == id);
            return View(customer);
        }
    }
}