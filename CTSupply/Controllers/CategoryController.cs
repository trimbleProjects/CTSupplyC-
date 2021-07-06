using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  CTSupply.Models;

namespace CTSupply.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            Product prods = new Product();

            List<Category> productList = prods.products.ToList();



            return View(productList);

        }
    }
}