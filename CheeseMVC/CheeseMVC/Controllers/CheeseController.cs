using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        public IActionResult Index()
        {

            ViewBag.cheeses = Cheeses;
            return View("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            Cheeses[name] = description;
            return Redirect("/Cheese");
        }

        [HttpGet]
        [Route("/Cheese/Remove")]
        public IActionResult Remove()
        {
            ViewBag.cheeses = Cheeses;
            return View("Remove");
        }

        [Route("/Cheese/Remove")]
        [HttpPost]
        public IActionResult RemoveCheeses(string[] selectedCheeses)
        {
            foreach (string cheeseName in selectedCheeses)
            {
                if (Cheeses.ContainsKey(cheeseName))
                {
                    Cheeses.Remove(cheeseName);
                }

            }
            return Redirect("/cheese");
        }

        [Route("/cheese/remove/{cheeseName}")]
        [HttpGet]
        public IActionResult RemoveSingleCheese(string cheeseName = "")
        {
            if (Cheeses.ContainsKey(cheeseName))
            {
                Cheeses.Remove(cheeseName);
            }

            return Redirect("/cheese");
        }
        
    }
}