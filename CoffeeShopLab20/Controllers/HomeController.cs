using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopLab20.Models;


namespace CoffeeShopLab20.Controllers
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

        public  ActionResult Success(Register r)
        {
            ViewBag.Message = "Welcome to Coffee Shop App; your " + r.FirstName + " " + r.LastName + " your " + r.Email + " " + r.Coffee + " " + r.Tea + " " + r.Bakery;

            return View();
        }

        public ActionResult Items()
        {
            ViewBag.Message = "Find the items you ordered here. Our Products include coffees, teas and bakery goodies.";
                        
            return View();
        }

        public ActionResult RegisterView()
        {
            ViewBag.Message = "Your information  .";

            return View();

        }

    }
}