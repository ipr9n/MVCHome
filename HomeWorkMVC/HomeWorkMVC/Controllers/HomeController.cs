using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWorkMVC.Models;
using ProductDatabase.DatabaseRepository;
using ProductDatabase.DatabaseContext;
using ProductDatabase.Entity;

namespace HomeWorkMVC.Controllers
{
    public class HomeController : Controller
    {
        ProductRepository repository = new ProductRepository(new ProductContext());
        public ActionResult Index()
        {
            return View(repository.Get());
        }

        public ActionResult Sort(string category)
        {
            return View("Index",repository.Get().Where(x=>x.Category.ToUpper() == category.ToUpper()));
        }

        public ActionResult ProductAdd(string Name, string Category)
        {
            repository.Add(new Product() {Category = Category, Name = Name});
            return View("Index", repository.Get());
        }
    }
}