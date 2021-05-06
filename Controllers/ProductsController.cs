using repository_pattern.Models;
using repository_pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace repository_pattern.Controllers
{
    public class ProductsController : Controller
    {
        ProductRepository repository = new ProductRepository();
        // GET: Products

        public ActionResult Details(int Id)
        {
            return View(repository.Get(Id));
        }

        [HttpGet]
        public ActionResult Delete(int Id,int owner)
        {
            repository.Delete(Id);
            return Redirect("/Student/Details/?Id=" + owner);
        }
        [HttpGet]
        public ActionResult AddNew(int owner)
        {
            ViewBag.owner = owner;
            return View();
        }

        [HttpPost]
        public ActionResult Addnew(Product pd)
        {
            repository.Insert(pd);
            return Redirect("/Student/Index");
        }
    }
}