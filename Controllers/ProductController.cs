using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyShopingApp9._0.Models;
using MyShopingApp9._0.Models.ViewModels;
using System;
using System.Runtime.CompilerServices;

namespace MyShopingApp9._0.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDBContext _context;
        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ProductVM productVM = new ProductVM();
            productVM.products = _context.Products.ToList();
            return View(productVM);
        }

        public IActionResult CreateUpdate(int id = 0)
        {

            if (id == 0)
            {
                Product product = new Product();
                return View(product);
            }
            else
            {
                var product = _context.Products.FirstOrDefault(p => p.Id == id);
                return View(product);
            }
        }

        [HttpPost]
        public IActionResult CreateUpdate(Product product)
        {
            if (product.Id == 0)
            {
                _context.Products.Add(product);
            }
            else
            {
                _context.Update(product);
            }

            _context.SaveChanges();
            TempData["ToastrMessage"] = "Product saved successfully!";
            TempData["ToastrType"] = "success";
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                TempData["ToastrMessage"] = "Product deleted successfully!";
                TempData["ToastrType"] = "success";
            }
            else
            {
                TempData["ToastrMessage"] = "Product not found!";
                TempData["ToastrType"] = "error";
            }
            return RedirectToAction("Index");
        }
    }
}
