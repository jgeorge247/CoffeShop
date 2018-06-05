using CoffeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        //this will go to my registration view
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Welcome(Customer data)
        {
            CoffeShopDBEntities ORM = new CoffeShopDBEntities();
            if (ModelState.IsValid)
            {
                try
                {
                    ORM.Customers.Add(data);
                    ORM.SaveChanges();
                    ViewBag.Message = $"Welcome {data.FirstName}! Your acccount was created successfully";
                }
                catch (Exception e)
                {

                    ViewBag.Message = $"Error: {e.Message} occured. Please try creating an account later";

                    //$"{data.Email} was not a valid customer";
                }

            }
            return View();
        }


        public ActionResult Add()
        {
            ViewBag.Message = "Add";
            return View();
        }
    }
}