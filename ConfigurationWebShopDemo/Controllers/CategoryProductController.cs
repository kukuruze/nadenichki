using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationWebShopDemo.Controllers
{
    public class CategoryProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ConfigurationTable()
        {
            return View();
        }
        public IActionResult CpuTable()
        {
            return View();
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
