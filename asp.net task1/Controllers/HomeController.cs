using Microsoft.AspNetCore.Mvc;

namespace asp.net_task1.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {

            ViewBag.Name = "Leyla";
            ViewBag.Surname = "Mammadova";
            ViewBag.Age = 27;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "+99455 555 55 55";
            return View();
        }
    }
}
