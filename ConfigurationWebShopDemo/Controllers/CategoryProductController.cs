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
    }
}
