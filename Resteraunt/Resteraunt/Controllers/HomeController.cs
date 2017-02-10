using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resteraunt.Models.Entities;

namespace Resteraunt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FoodDbContext db = new FoodDbContext();
            var lunchFoodList = db.foods.SqlQuery("Select * from tbl_food  where menu_id = 1").ToList<Food>();
            var dinnerFoodList = db.foods.SqlQuery("Select * from tbl_food  where menu_id = 2").ToList<Food>();
            var all_food = db.foods.SqlQuery("select * from tbl_food where active = 1").ToList<Food>();

            ViewData["LUNCH_FOOD"] = lunchFoodList;
            ViewData["DINNER_FOOD"] = dinnerFoodList;
            ViewData["ALL_FOOD"] = all_food;
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
    }
}