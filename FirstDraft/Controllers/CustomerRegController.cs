using FirstDraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstDraft.Controllers
{
    public class CustomerRegController : Controller
    {
        // GET: CustomerReg
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customers Customers)
        {
            string Forname = Customers.Forname;
            string Surname = Customers.Surname;
            string Email = Customers.Email;
            string Password = Customers.Password;

            return View();
        }
    }
}