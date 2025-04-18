using Microsoft.AspNetCore.Mvc;
using MyShopingApp9._0.Models;
using System.Runtime.CompilerServices;

namespace MyShopingApp9._0.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CreateUpdate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUpdate(Product product)
        {
            return View();
        }
    }
}
