using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigurationWebShopDemo.Data;
using ConfigurationWebShopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConfigurationWebShopDemo.Controllers
{
    public class SignUpController : Controller
    {
        private readonly SignUpDbContext _db;

        public SignUpController(SignUpDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //return RedirectToAction("Create");
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

       [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SignUp obj)
        {
            _db.SignUp.Add(obj);
            _db.SaveChanges();  
            return View();
        }
    }
}
