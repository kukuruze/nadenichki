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
            IEnumerable<GPUs> objList = _db.GPUs;
            return View(objList);
        }
        public IActionResult HddTable()
        {
            IEnumerable<HDDs> objList = _db.HDDs;
            return View(objList);
        }
        public IActionResult MotherboardTable()
        {
            IEnumerable<Mother_Boards> objList = _db.Mother_Boards;
            return View(objList);
        }
        public IActionResult RamTable()
        {
            IEnumerable<RAMs> objList = _db.RAMs;
            return View(objList);
        }
        public IActionResult SsdTable()
        {
            IEnumerable<SSDs> objList = _db.SSDs;
            return View(objList);
        }
    }
}
