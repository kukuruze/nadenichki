using ConfigurationWebShopDemo.Data;
using ConfigurationWebShopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Controllers
{
    public class CategoryProductController : Controller
    {
        private readonly CompdatabaseDbContext _db;

        public CategoryProductController(CompdatabaseDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ConfigurationTable()
        {
            IEnumerable<Configurations> objList = _db.Configurations;
            return View(objList);
        }
        public IActionResult CpuTable()
        {
            IEnumerable<CPUs> objList = _db.CPUs;
            return View(objList);
        }
        public IActionResult GpuTable()
        {
            return View();
        }
        public IActionResult HddTable()
        {
            return View();
        }
        public IActionResult MotherboardTable()
        {
            return View();
        }
        public IActionResult RamTable()
        {
            return View();
        }
        public IActionResult SsdTable()
        {
            return View();
        }
    }
}
