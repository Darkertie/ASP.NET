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
        public ActionResult RegistrationPage()
        {
            return View();
        }

        

        
        public ActionResult Autherize()
        {
            return View("Index");
        }
        [HttpPost]
        public ActionResult RegistrationPage(Customers Models)
        {
            string Forname = Models.Forname;
            string Surname = Models.Surname;
            string Email = Models.Email;
            string Password = Models.Password;

            return View("Index");
        }
    }
}