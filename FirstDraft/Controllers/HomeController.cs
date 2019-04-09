using FirstDraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstDraft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RegistrationPage()
        {
            ViewBag.Message = "Your registration page.";

            return View();
        }

        public ActionResult RegistrationPage(Customers Models)
        {
            string Forname = Models.Forname;
            string Surname = Models.Surname;
            string Email = Models.Email;
            string Password = Models.Password;

            return View("Index");
        }

        public ActionResult SClubRideEvents()
        {
            ViewBag.Message = "Your SClubRideEvents page.";

            return View();
        }

        public ActionResult ClubkitBuy()
        {
            ViewBag.Message = "Your ClubkitBuy page.";

            return View();
        }

        public ActionResult Orders()
        {
            ViewBag.Message = "Your Orders page.";

            return View();
        }

        public ActionResult CityRidesPP()
        {
            ViewBag.Message = "Your CityRidesPP page.";

            return View();
        }

        public ActionResult CountryRidesPP()
        {
            ViewBag.Message = "Your CountryRidesPP page.";

            return View();
        }

        public ActionResult GroupRidesPP()
        {
            ViewBag.Message = "Your GroupRidesPP page.";

            return View();
        }

        public ActionResult SafetyRidesPP()
        {
            ViewBag.Message = "Your SafetyRidesPP page.";

            return View();
        }

        public ActionResult PedalsPP()
        {
            ViewBag.Message = "Your PedalsPP page.";

            return View();
        }

        public ActionResult HelmetPP()
        {
            ViewBag.Message = "Your HelmetPP page.";

            return View();
        }

        public ActionResult BikePumpPP()
        {
            ViewBag.Message = "Your BikePumpPP page.";

            return View();
        }

        public ActionResult BikeFramePP()
        {
            ViewBag.Message = "Your BikeFramePP page.";

            return View();
        }

        public ActionResult BuyPage()
        {
            ViewBag.Message = "Your Buy page.";

            return View();
        }

        public ActionResult customers()
        {
            ViewBag.Message = "Your Customer page.";

            return View();
        }
    }
}