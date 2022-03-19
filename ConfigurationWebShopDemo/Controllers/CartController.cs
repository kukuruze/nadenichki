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
            IEnumerable<Product> objList = _db.Product;
            return View(objList);
        }

        public IActionResult RemoveFromCart(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Product.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.Product.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddToCartCPU(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.CPUs.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            int count = _db.Product.Count();

            Product prod = new Product();

            prod.Id = count + 1;
            prod.Model = obj.cpu_model;
            prod.Type = "cpu";
            prod.Price = obj.cpu_price;

            bool found = false;

            foreach (var item in _db.Product)
            {
                if(item.Model == prod.Model && item.Type == prod.Type)
                {
                    item.Quantity++;
                    found = true;
                }
            }
            if (prod.Quantity <= 0)
            {
                prod.Quantity = 1;
                
            }
            if(!found)
            {
                _db.Product.Add(prod);
            }

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult AddToCartGPU(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.GPUs.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            int count = _db.Product.Count();

            Product prod = new Product();

            prod.Id = count + 1;
            prod.Model = obj.gpu_model;
            prod.Type = "gpu";
            prod.Price = obj.gpu_price;
            bool found = false;

            foreach (var item in _db.Product)
            {
                if (item.Model == prod.Model && item.Type == prod.Type)
                {
                    item.Quantity++;
                    found = true;
                }
            }
            if (prod.Quantity <= 0)
            {
                prod.Quantity = 1;

            }
            if (!found)
            {
                _db.Product.Add(prod);
            }

            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddToCartHDD(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.HDDs.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            int count = _db.Product.Count();

            Product prod = new Product();

            prod.Id = count + 1;
            prod.Model = obj.hdd_capacity + " TB HDD";
            prod.Type = "hdd";
            prod.Price = obj.hdd_price;

            bool found = false;

            foreach (var item in _db.Product)
            {
                if (item.Model == prod.Model && item.Type == prod.Type)
                {
                    item.Quantity++;
                    found = true;
                }
            }
            if (prod.Quantity <= 0)
            {
                prod.Quantity = 1;

            }
            if (!found)
            {
                _db.Product.Add(prod);
            }

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult AddToCartMotherboard(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Mother_Boards.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            int count = _db.Product.Count();

            Product prod = new Product();

            prod.Id = count + 1;
            prod.Model = obj.mother_board_model;
            prod.Type = "motherboard";
            prod.Price = obj.mother_board_price;

            bool found = false;

            foreach (var item in _db.Product)
            {
                if (item.Model == prod.Model && item.Type == prod.Type)
                {
                    item.Quantity++;
                    found = true;
                }
            }
            if (prod.Quantity <= 0)
            {
                prod.Quantity = 1;

            }
            if (!found)
            {
                _db.Product.Add(prod);
            }

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult AddToCartSSD(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.SSDs.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            int count = _db.Product.Count();

            Product prod = new Product();

            prod.Id = count + 1;
            prod.Model = obj.ssd_capacity + " GB SSD";
            prod.Type = "ssd";
            prod.Price = obj.ssd_price;
            bool found = false;

            foreach (var item in _db.Product)
            {
                if (item.Model == prod.Model && item.Type == prod.Type)
                {
                    item.Quantity++;
                    found = true;
                }
            }
            if (prod.Quantity <= 0)
            {
                prod.Quantity = 1;

            }
            if (!found)
            {
                _db.Product.Add(prod);
            }

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult AddToCartRAM(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.RAMs.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            int count = _db.Product.Count();
            
            Product prod = new Product();

            prod.Id = count + 1;
            prod.Model = obj.ram_capacity + " GB RAM";
            prod.Type = "ram";
            prod.Price = obj.ram_price;

            bool found = false;

            foreach (var item in _db.Product)
            {
                if (item.Model == prod.Model && item.Type == prod.Type)
                {
                    item.Quantity++;
                    found = true;
                }
            }
            if (prod.Quantity <= 0)
            {
                prod.Quantity = 1;

            }
            if (!found)
            {
                _db.Product.Add(prod);
            }

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult AddToCartConfiguration(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Configurations.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            int count = _db.Product.Count();

            Product prod = new Product();

            prod.Id = count + 1;
            prod.Model = "GamingComputer Configuration №" + id.ToString();
            prod.Type = "configuration";
            prod.Price = obj.Price;

            bool found = false;

            foreach (var item in _db.Product)
            {
                if (item.Model == prod.Model && item.Type == prod.Type)
                {
                    item.Quantity++;
                    found = true;
                }
            }
            if (prod.Quantity <= 0)
            {
                prod.Quantity = 1;

            }
            if (!found)
            {
                _db.Product.Add(prod);
            }

            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
