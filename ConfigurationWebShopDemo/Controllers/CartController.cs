using ConfigurationWebShopDemo.Data;
using ConfigurationWebShopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Controllers
{
    public class CartController : Controller
    {
        private readonly CompdatabaseDbContext _db;

        public CartController(CompdatabaseDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> objList = _db.Products;
            return View(objList);
        }

        public IActionResult AddToCartCPU(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.CPUs.Find(id);
            Product prod = new Product();
            prod.Id = obj.cpu_id;
            prod.Model = obj.cpu_model;
            prod.Type = "cpu";
            prod.Price = obj.cpu_price;

            _db.Products.Add(prod);
            _db.SaveChanges();

            if (obj == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        public IActionResult AddToCartRAM(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.RAMs.Find(id);
            Product prod = new Product();
            prod.Id = obj.ram_id;
            prod.Model = obj.ram_capacity;
            prod.Type = "ram";
            prod.Price = obj.ram_price;

            _db.Products.Add(prod);
            _db.SaveChanges();

            if (obj == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }
    }
}
